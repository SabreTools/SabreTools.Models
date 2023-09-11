using System.Xml.Serialization;

namespace SabreTools.Models.PortableExecutable
{
    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    [XmlRoot(ElementName = "assembly", Namespace = "urn:schemas-microsoft-com:asm.v1")]
    public sealed class AssemblyManifest
    {
        [XmlAttribute("manifestVersion")]
#if NET48
        public string ManifestVersion { get; set; }
#else
        public string? ManifestVersion { get; set; }
#endif

        #region Group

        [XmlElement("assemblyIdentity")]
#if NET48
        public AssemblyIdentity[] AssemblyIdentities { get; set; }
#else
        public AssemblyIdentity?[]? AssemblyIdentities { get; set; }
#endif

        [XmlElement("noInheritable")]
#if NET48
        public AssemblyNoInheritable[] NoInheritables { get; set; }
#else
        public AssemblyNoInheritable?[]? NoInheritables { get; set; }
#endif

        #endregion

        #region Group

        [XmlElement("description")]
#if NET48
        public AssemblyDescription Description { get; set; }
#else
        public AssemblyDescription? Description { get; set; }
#endif

        [XmlElement("noInherit")]
#if NET48
        public AssemblyNoInherit NoInherit { get; set; }
#else
        public AssemblyNoInherit? NoInherit { get; set; }
#endif

        //[XmlElement("noInheritable")]
        //public AssemblyNoInheritable NoInheritable { get; set; }

        [XmlElement("comInterfaceExternalProxyStub")]
#if NET48
        public AssemblyCOMInterfaceExternalProxyStub[] COMInterfaceExternalProxyStub { get; set; }
#else
        public AssemblyCOMInterfaceExternalProxyStub?[]? COMInterfaceExternalProxyStub { get; set; }
#endif

        [XmlElement("dependency")]
#if NET48
        public AssemblyDependency[] Dependency { get; set; }
#else
        public AssemblyDependency?[]? Dependency { get; set; }
#endif

        [XmlElement("file")]
#if NET48
        public AssemblyFile[] File { get; set; }
#else
        public AssemblyFile?[]? File { get; set; }
#endif

        [XmlElement("clrClass")]
#if NET48
        public AssemblyCommonLanguageRuntimeClass[] CLRClass { get; set; }
#else
        public AssemblyCommonLanguageRuntimeClass?[]? CLRClass { get; set; }
#endif

        [XmlElement("clrSurrogate")]
#if NET48
        public AssemblyCommonLanguageSurrogateClass[] CLRSurrogate { get; set; }
#else
        public AssemblyCommonLanguageSurrogateClass?[]? CLRSurrogate { get; set; }
#endif

        #endregion

        [XmlAnyElement]
#if NET48
        public object[] EverythingElse { get; set; }
#else
        public object[]? EverythingElse { get; set; }
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyActiveCodePage
    {
        [XmlText]
#if NET48
        public string Value { get; set; }
#else
        public string? Value { get; set; }
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyAutoElevate
    {
        [XmlText]
#if NET48
        public string Value { get; set; }
#else
        public string? Value { get; set; }
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyBindingRedirect
    {
        [XmlAttribute("oldVersion")]
#if NET48
        public string OldVersion { get; set; }
#else
        public string? OldVersion { get; set; }
#endif

        [XmlAttribute("newVersion")]
#if NET48
        public string NewVersion { get; set; }
#else
        public string? NewVersion { get; set; }
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyCOMClass
    {
        [XmlAttribute("clsid")]
#if NET48
        public string CLSID { get; set; }
#else
        public string? CLSID { get; set; }
#endif

        [XmlAttribute("threadingModel")]
#if NET48
        public string ThreadingModel { get; set; }
#else
        public string? ThreadingModel { get; set; }
#endif

        [XmlAttribute("progid")]
#if NET48
        public string ProgID { get; set; }
#else
        public string? ProgID { get; set; }
#endif

        [XmlAttribute("tlbid")]
#if NET48
        public string TLBID { get; set; }
#else
        public string? TLBID { get; set; }
#endif

        [XmlAttribute("description")]
#if NET48
        public string Description { get; set; }
#else
        public string? Description { get; set; }
#endif

        [XmlElement("progid")]
#if NET48
        public AssemblyProgID[] ProgIDs { get; set; }
#else
        public AssemblyProgID?[]? ProgIDs { get; set; }
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyCOMInterfaceExternalProxyStub
    {
        [XmlAttribute("iid")]
#if NET48
        public string IID { get; set; }
#else
        public string? IID { get; set; }
#endif

        [XmlAttribute("name")]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        [XmlAttribute("tlbid")]
#if NET48
        public string TLBID { get; set; }
#else
        public string? TLBID { get; set; }
#endif

        [XmlAttribute("numMethods")]
#if NET48
        public string NumMethods { get; set; }
#else
        public string? NumMethods { get; set; }
#endif

        [XmlAttribute("proxyStubClsid32")]
#if NET48
        public string ProxyStubClsid32 { get; set; }
#else
        public string? ProxyStubClsid32 { get; set; }
#endif

        [XmlAttribute("baseInterface")]
#if NET48
        public string BaseInterface { get; set; }
#else
        public string? BaseInterface { get; set; }
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyCOMInterfaceProxyStub
    {
        [XmlAttribute("iid")]
#if NET48
        public string IID { get; set; }
#else
        public string? IID { get; set; }
#endif

        [XmlAttribute("name")]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        [XmlAttribute("tlbid")]
#if NET48
        public string TLBID { get; set; }
#else
        public string? TLBID { get; set; }
#endif

        [XmlAttribute("numMethods")]
#if NET48
        public string NumMethods { get; set; }
#else
        public string? NumMethods { get; set; }
#endif

        [XmlAttribute("proxyStubClsid32")]
#if NET48
        public string ProxyStubClsid32 { get; set; }
#else
        public string? ProxyStubClsid32 { get; set; }
#endif

        [XmlAttribute("baseInterface")]
#if NET48
        public string BaseInterface { get; set; }
#else
        public string? BaseInterface { get; set; }
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyCommonLanguageRuntimeClass
    {
        [XmlAttribute("name")]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        [XmlAttribute("clsid")]
#if NET48
        public string CLSID { get; set; }
#else
        public string? CLSID { get; set; }
#endif

        [XmlAttribute("progid")]
#if NET48
        public string ProgID { get; set; }
#else
        public string? ProgID { get; set; }
#endif

        [XmlAttribute("tlbid")]
#if NET48
        public string TLBID { get; set; }
#else
        public string? TLBID { get; set; }
#endif

        [XmlAttribute("description")]
#if NET48
        public string Description { get; set; }
#else
        public string? Description { get; set; }
#endif

        [XmlAttribute("runtimeVersion")]
#if NET48
        public string RuntimeVersion { get; set; }
#else
        public string? RuntimeVersion { get; set; }
#endif

        [XmlAttribute("threadingModel")]
#if NET48
        public string ThreadingModel { get; set; }
#else
        public string? ThreadingModel { get; set; }
#endif

        [XmlElement("progid")]
#if NET48
        public AssemblyProgID[] ProgIDs { get; set; }
#else
        public AssemblyProgID?[]? ProgIDs { get; set; }
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyCommonLanguageSurrogateClass
    {
        [XmlAttribute("clsid")]
#if NET48
        public string CLSID { get; set; }
#else
        public string? CLSID { get; set; }
#endif

        [XmlAttribute("name")]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        [XmlAttribute("runtimeVersion")]
#if NET48
        public string RuntimeVersion { get; set; }
#else
        public string? RuntimeVersion { get; set; }
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyDependency
    {
        [XmlElement("dependentAssembly")]
#if NET48
        public AssemblyDependentAssembly DependentAssembly { get; set; }
#else
        public AssemblyDependentAssembly? DependentAssembly { get; set; }
#endif

        [XmlAttribute("optional")]
#if NET48
        public string Optional { get; set; }
#else
        public string? Optional { get; set; }
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyDependentAssembly
    {
        [XmlElement("assemblyIdentity")]
#if NET48
        public AssemblyIdentity AssemblyIdentity { get; set; }
#else
        public AssemblyIdentity? AssemblyIdentity { get; set; }
#endif

        [XmlElement("bindingRedirect")]
#if NET48
        public AssemblyBindingRedirect[] BindingRedirect { get; set; }
#else
        public AssemblyBindingRedirect?[]? BindingRedirect { get; set; }
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyDescription
    {
        [XmlText]
#if NET48
        public string Value { get; set; }
#else
        public string? Value { get; set; }
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyDisableTheming
    {
        [XmlText]
#if NET48
        public string Value { get; set; }
#else
        public string? Value { get; set; }
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyDisableWindowFiltering
    {
        [XmlText]
#if NET48
        public string Value { get; set; }
#else
        public string? Value { get; set; }
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyDPIAware
    {
        [XmlText]
#if NET48
        public string Value { get; set; }
#else
        public string? Value { get; set; }
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyDPIAwareness
    {
        [XmlText]
#if NET48
        public string Value { get; set; }
#else
        public string? Value { get; set; }
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyFile
    {
        [XmlAttribute("name")]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        [XmlAttribute("hash")]
#if NET48
        public string Hash { get; set; }
#else
        public string? Hash { get; set; }
#endif

        [XmlAttribute("hashalg")]
#if NET48
        public string HashAlgorithm { get; set; }
#else
        public string? HashAlgorithm { get; set; }
#endif

        [XmlAttribute("size")]
#if NET48
        public string Size { get; set; }
#else
        public string? Size { get; set; }
#endif

        #region Group

        [XmlElement("comClass")]
#if NET48
        public AssemblyCOMClass[] COMClass { get; set; }
#else
        public AssemblyCOMClass?[]? COMClass { get; set; }
#endif

        [XmlElement("comInterfaceProxyStub")]
#if NET48
        public AssemblyCOMInterfaceProxyStub[] COMInterfaceProxyStub { get; set; }
#else
        public AssemblyCOMInterfaceProxyStub?[]? COMInterfaceProxyStub { get; set; }
#endif

        [XmlElement("typelib")]
#if NET48
        public AssemblyTypeLib[] Typelib { get; set; }
#else
        public AssemblyTypeLib?[]? Typelib { get; set; }
#endif

        [XmlElement("windowClass")]
#if NET48
        public AssemblyWindowClass[] WindowClass { get; set; }
#else
        public AssemblyWindowClass?[]? WindowClass { get; set; }
#endif

        #endregion
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyGDIScaling
    {
        [XmlText]
#if NET48
        public string Value { get; set; }
#else
        public string? Value { get; set; }
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyHeapType
    {
        [XmlText]
#if NET48
        public string Value { get; set; }
#else
        public string? Value { get; set; }
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyHighResolutionScrollingAware
    {
        [XmlText]
#if NET48
        public string Value { get; set; }
#else
        public string? Value { get; set; }
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyIdentity
    {
        [XmlAttribute("name")]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        [XmlAttribute("version")]
#if NET48
        public string Version { get; set; }
#else
        public string? Version { get; set; }
#endif

        [XmlAttribute("type")]
#if NET48
        public string Type { get; set; }
#else
        public string? Type { get; set; }
#endif

        [XmlAttribute("processorArchitecture")]
#if NET48
        public string ProcessorArchitecture { get; set; }
#else
        public string? ProcessorArchitecture { get; set; }
#endif

        [XmlAttribute("publicKeyToken")]
#if NET48
        public string PublicKeyToken { get; set; }
#else
        public string? PublicKeyToken { get; set; }
#endif

        [XmlAttribute("language")]
#if NET48
        public string Language { get; set; }
#else
        public string? Language { get; set; }
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyLongPathAware
    {
        [XmlText]
#if NET48
        public string Value { get; set; }
#else
        public string? Value { get; set; }
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyNoInherit
    {
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyNoInheritable
    {
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyPrinterDriverIsolation
    {
        [XmlText]
#if NET48
        public string Value { get; set; }
#else
        public string? Value { get; set; }
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyProgID
    {
        [XmlText]
#if NET48
        public string Value { get; set; }
#else
        public string? Value { get; set; }
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblySupportedOS
    {
        [XmlAttribute("Id")]
#if NET48
        public string Id { get; set; }
#else
        public string? Id { get; set; }
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyTypeLib
    {
        [XmlElement("tlbid")]
#if NET48
        public string TLBID { get; set; }
#else
        public string? TLBID { get; set; }
#endif

        [XmlElement("version")]
#if NET48
        public string Version { get; set; }
#else
        public string? Version { get; set; }
#endif

        [XmlElement("helpdir")]
#if NET48
        public string HelpDir { get; set; }
#else
        public string? HelpDir { get; set; }
#endif

        [XmlElement("resourceid")]
#if NET48
        public string ResourceID { get; set; }
#else
        public string? ResourceID { get; set; }
#endif

        [XmlElement("flags")]
#if NET48
        public string Flags { get; set; }
#else
        public string? Flags { get; set; }
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyUltraHighResolutionScrollingAware
    {
        [XmlText]
#if NET48
        public string Value { get; set; }
#else
        public string? Value { get; set; }
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyWindowClass
    {
        [XmlAttribute("versioned")]
#if NET48
        public string Versioned { get; set; }
#else
        public string? Versioned { get; set; }
#endif

        [XmlText]
#if NET48
        public string Value { get; set; }
#else
        public string? Value { get; set; }
#endif
    }

    // TODO: Left off at <ElementType name="progid" />
}
