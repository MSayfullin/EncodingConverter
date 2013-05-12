# Encoding Converter
Text files encoding analyzer and converter.  
Declaration and meta encoding attributes for XML and HTML files are also updated on convert.

For files filtering and ordering check options.  
By default next file types are taken into account:
 * Text based - txt
 * Xml based - xml, fb2
 * Html based - htm, html

Encoding is resolved by [C# port of the Mozilla CharDet Character Set Detector](http://code.google.com/p/chardetsharp/).

## Known Issues
 * There are 1000 files limit for loading at the same time (fix is on the way).
 * CharDet is not 100% good at guessing file encoding. Let's say it is approximately 40%.

## Download
[v1.0](https://encodingconverter.codeplex.com/downloads/get/679223)

## Licenses
[The MIT License (MIT)](https://github.com/MSayfullin/EncodingConverter/blob/master/LICENSE)

CharDetSharp  
[Mozilla Public License 1.1](http://www.mozilla.org/MPL/)