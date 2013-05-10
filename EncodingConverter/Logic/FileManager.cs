using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using dokas.EncodingConverter.Exceptions;

namespace dokas.EncodingConverter.Logic
{
    internal sealed class FileManager
    {
        private const string ConvertedFolderDefaultName = "Converted";

        private readonly ITextWrapper _sourcePath;
        private readonly ITextWrapper _destinationPath;
        private string _destinationPathGeneratedValue;

        public FileManager(ITextWrapper sourcePath, ITextWrapper destinationPath)
        {
            if (sourcePath == null)
            {
                throw new ArgumentNullException("sourcePath");
            }
            if (destinationPath == null)
            {
                throw new ArgumentNullException("destinationPath");
            }

            _sourcePath = sourcePath;
            _destinationPath = destinationPath;
            _destinationPathGeneratedValue = String.Empty;
        }

        public void SetDestinationPath()
        {
            if (_destinationPath.Value.Length == 0
                || _destinationPath.Value.ToLower() == _destinationPathGeneratedValue.ToLower())
            {
                _destinationPath.Value = Path.Combine(_sourcePath.Value, ConvertedFolderDefaultName);
                _destinationPathGeneratedValue = _destinationPath.Value;
            }
        }

        public IEnumerable<FileData> GetFilePaths()
        {
            return SettingsProvider.SearchPatterns
                .AsParallel()
                .SelectMany(pattern => GetFilesBy(pattern))
                .Distinct();
        }

        public byte[] Load(string filePath)
        {
            return LoadFile(filePath);
        }

        public void Save(string filePath, byte[] bytes)
        {
            EnsureDestinationFolderExists();
            SaveFile(filePath, bytes);
        }

        #region Helpers

        private IEnumerable<FileData> GetFilesBy(string pattern)
        {
            try
            {
                return Directory
                    .EnumerateFiles(_sourcePath.Value, pattern, SearchOption.AllDirectories)
                    .Select(p => new FileData(p));
            }
            catch (ArgumentNullException)
            {
                // if it fails, then something is very wrong
                throw;
            }
            catch (ArgumentException ex)
            {
                throw new RecoverableException(
                    "Source folder is not specified or has incorrect symbols in path.", ex);
            }
            catch (PathTooLongException ex)
            {
                throw new RecoverableException(
                    "Source folder path exceeds the system-defined maximum length. Paths must be less than 248 characters.", ex);
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new RecoverableException(
                    "Source folder path is invalid: " + ex.Message, ex);
            }
            catch (IOException ex)
            {
                throw new RecoverableException(ex.Message, ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new RecoverableException(
                    "Source folder cannot be read." + Environment.NewLine + ex.Message, ex);
            }
            catch (SecurityException ex)
            {
                throw new RecoverableException(
                    "Source folder cannot be read. Check that you have sufficient permissions.", ex);
            }
        }

        private void EnsureDestinationFolderExists()
        {
            if (!Directory.Exists(_destinationPath.Value))
            {
                try
                {
                    Directory.CreateDirectory(_destinationPath.Value);
                }
                catch (ArgumentNullException ex)
                {
                    throw new RecoverableException(
                        "Destination folder is not specified.", ex);
                }
                catch (ArgumentException ex)
                {
                    throw new RecoverableException(
                        "Destination folder is not specified or has incorrect symbols in path.", ex);
                }
                catch (NotSupportedException ex)
                {
                    throw new RecoverableException(
                        "Destination folder path contains a colon character (:) that is not part of a drive label ('C:\').", ex);
                }
                catch (PathTooLongException ex)
                {
                    throw new RecoverableException(
                        "Destination folder path exceeds the system-defined maximum length. Paths must be less than 248 characters.", ex);
                }
                catch (DirectoryNotFoundException ex)
                {
                    throw new RecoverableException(
                        "Destination folder path is invalid: " + ex.Message, ex);
                }
                catch (IOException ex)
                {
                    throw new RecoverableException(ex.Message, ex);
                }
                catch (UnauthorizedAccessException ex)
                {
                    throw new RecoverableException(
                        "Destination folder cannot be created. Check that you have sufficient permissions.", ex);
                }
            }
        }

        private byte[] LoadFile(string filePath)
        {
            try
            {
                return File.ReadAllBytes(filePath);
            }
            catch (ArgumentNullException)
            {
                // this should have been failed earlier
                // if it fails here something is went wrong
                throw;
            }
            catch (ArgumentException ex)
            {
                throw new RecoverableException(
                    "File path is not specified or has incorrect symbols in path.", ex);
            }
            catch (NotSupportedException ex)
            {
                throw new RecoverableException(
                    "File path is not specified or has incorrect symbols in path.", ex);
            }
            catch (PathTooLongException ex)
            {
                throw new RecoverableException(
                    "File name exceeds the system-defined maximum length. It must be less than 260 characters.", ex);
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new RecoverableException(
                    "Source folder path is invalid: " + ex.Message, ex);
            }
            catch (FileNotFoundException ex)
            {
                throw new RecoverableException(
                    "File cannot be read from path specified.", ex);
            }
            catch (IOException ex)
            {
                throw new RecoverableException(ex.Message, ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new RecoverableException(
                    "File cannot be read." + Environment.NewLine + ex.Message, ex);
            }
            catch (SecurityException ex)
            {
                throw new RecoverableException(
                    "File cannot be read. Check that you have sufficient permissions.", ex);
            }
        }

        private void SaveFile(string filePath, byte[] bytes)
        {
            try
            {
                File.WriteAllBytes(Path.Combine(_destinationPath.Value, Path.GetFileName(filePath)), bytes);
            }
            catch (ArgumentNullException)
            {
                // this should have been failed earlier
                // if it fails here something is went wrong
                throw;
            }
            catch (ArgumentException)
            {
                // this should have been failed earlier
                // if it fails here something is went wrong
                throw;
            }
            catch (NotSupportedException)
            {
                // this should have been failed earlier
                // if it fails here something is went wrong
                throw;
            }
            catch (PathTooLongException ex)
            {
                throw new RecoverableException(
                    "File name exceeds the system-defined maximum length. It must be less than 260 characters.", ex);
            }
            catch (DirectoryNotFoundException)
            {
                // this should have been failed earlier
                // if it fails here something is went wrong
                throw;
            }
            catch (IOException ex)
            {
                throw new RecoverableException(ex.Message, ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new RecoverableException(
                    "Converted file cannot be created." + Environment.NewLine + ex.Message, ex);
            }
            catch (SecurityException ex)
            {
                throw new RecoverableException(
                    "Converted file cannot be created. Check that you have sufficient permissions.", ex);
            }
        }

        #endregion
    }
}
