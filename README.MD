# SabreTools.Models

This library comprises of models that represent either directly serializable or representative structures for all SabreTools projects. All of the main models representing metadata files should have parsers created outside of the current code.

In most completed models for serialization, there is a section that looks like the following:

```c#
        #region DO NOT USE IN PRODUCTION

        /// <remarks>Should be empty</remarks>
        [XmlAnyAttribute]
        public XmlAttribute[]? ADDITIONAL_ATTRIBUTES { get; set; }

        /// <remarks>Should be empty</remarks>
        [XmlAnyElement]
        public object[]? ADDITIONAL_ELEMENTS { get; set; }

        #endregion
```

This code should be removed before the models are used. This is only included during debugging and implementation as to ensure that there are no notable holes in the models that would disallow 1:1 replication of inputs.

## Missing Metadata Models

The following metadata file formats do not have models included in this library yet and, as such, do not have serializers:

- Missfile
- SabreJSON
- SabreDAT XML
