using System.Xml.Serialization;

namespace SabreTools.Models.PortableExecutable
{
    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    [XmlRoot(ElementName = "assembly", Namespace = "urn:schemas-microsoft-com:asm.v1")]
    public sealed class AssemblyManifest
    {
        [XmlAttribute("manifestVersion")]
#if NET48
        public string ManifestVersion;
#else
        public string? ManifestVersion;
#endif

        #region Group

        [XmlElement("assemblyIdentity")]
#if NET48
        public AssemblyIdentity[] AssemblyIdentities;
#else
        public AssemblyIdentity[]? AssemblyIdentities;
#endif

        [XmlElement("noInheritable")]
#if NET48
        public AssemblyNoInheritable[] NoInheritables;
#else
        public AssemblyNoInheritable[]? NoInheritables;
#endif

        #endregion

        #region Group

        [XmlElement("description")]
#if NET48
        public AssemblyDescription Description;
#else
        public AssemblyDescription? Description;
#endif

        [XmlElement("noInherit")]
#if NET48
        public AssemblyNoInherit NoInherit;
#else
        public AssemblyNoInherit? NoInherit;
#endif

        //[XmlElement("noInheritable")]
        //public AssemblyNoInheritable NoInheritable;

        [XmlElement("comInterfaceExternalProxyStub")]
#if NET48
        public AssemblyCOMInterfaceExternalProxyStub[] COMInterfaceExternalProxyStub;
#else
        public AssemblyCOMInterfaceExternalProxyStub[]? COMInterfaceExternalProxyStub;
#endif

        [XmlElement("dependency")]
#if NET48
        public AssemblyDependency[] Dependency;
#else
        public AssemblyDependency[]? Dependency;
#endif

        [XmlElement("file")]
#if NET48
        public AssemblyFile[] File;
#else
        public AssemblyFile[]? File;
#endif

        [XmlElement("clrClass")]
#if NET48
        public AssemblyCommonLanguageRuntimeClass[] CLRClass;
#else
        public AssemblyCommonLanguageRuntimeClass[]? CLRClass;
#endif

        [XmlElement("clrSurrogate")]
#if NET48
        public AssemblyCommonLanguageSurrogateClass[] CLRSurrogate;
#else
        public AssemblyCommonLanguageSurrogateClass[]? CLRSurrogate;
#endif

        #endregion

        [XmlAnyElement]
#if NET48
        public object[] EverythingElse;
#else
        public object[]? EverythingElse;
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyActiveCodePage
    {
        [XmlText]
#if NET48
        public string Value;
#else
        public string? Value;
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyAutoElevate
    {
        [XmlText]
#if NET48
        public string Value;
#else
        public string? Value;
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyBindingRedirect
    {
        [XmlAttribute("oldVersion")]
#if NET48
        public string OldVersion;
#else
        public string? OldVersion;
#endif

        [XmlAttribute("newVersion")]
#if NET48
        public string NewVersion;
#else
        public string? NewVersion;
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyCOMClass
    {
        [XmlAttribute("clsid")]
#if NET48
        public string CLSID;
#else
        public string? CLSID;
#endif

        [XmlAttribute("threadingModel")]
#if NET48
        public string ThreadingModel;
#else
        public string? ThreadingModel;
#endif

        [XmlAttribute("progid")]
#if NET48
        public string ProgID;
#else
        public string? ProgID;
#endif

        [XmlAttribute("tlbid")]
#if NET48
        public string TLBID;
#else
        public string? TLBID;
#endif

        [XmlAttribute("description")]
#if NET48
        public string Description;
#else
        public string? Description;
#endif

        [XmlElement("progid")]
#if NET48
        public AssemblyProgID[] ProgIDs;
#else
        public AssemblyProgID[]? ProgIDs;
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyCOMInterfaceExternalProxyStub
    {
        [XmlAttribute("iid")]
#if NET48
        public string IID;
#else
        public string? IID;
#endif

        [XmlAttribute("name")]
#if NET48
        public string Name;
#else
        public string? Name;
#endif

        [XmlAttribute("tlbid")]
#if NET48
        public string TLBID;
#else
        public string? TLBID;
#endif

        [XmlAttribute("numMethods")]
#if NET48
        public string NumMethods;
#else
        public string? NumMethods;
#endif

        [XmlAttribute("proxyStubClsid32")]
#if NET48
        public string ProxyStubClsid32;
#else
        public string? ProxyStubClsid32;
#endif

        [XmlAttribute("baseInterface")]
#if NET48
        public string BaseInterface;
#else
        public string? BaseInterface;
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyCOMInterfaceProxyStub
    {
        [XmlAttribute("iid")]
#if NET48
        public string IID;
#else
        public string? IID;
#endif

        [XmlAttribute("name")]
#if NET48
        public string Name;
#else
        public string? Name;
#endif

        [XmlAttribute("tlbid")]
#if NET48
        public string TLBID;
#else
        public string? TLBID;
#endif

        [XmlAttribute("numMethods")]
#if NET48
        public string NumMethods;
#else
        public string? NumMethods;
#endif

        [XmlAttribute("proxyStubClsid32")]
#if NET48
        public string ProxyStubClsid32;
#else
        public string? ProxyStubClsid32;
#endif

        [XmlAttribute("baseInterface")]
#if NET48
        public string BaseInterface;
#else
        public string? BaseInterface;
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyCommonLanguageRuntimeClass
    {
        [XmlAttribute("name")]
#if NET48
        public string Name;
#else
        public string? Name;
#endif

        [XmlAttribute("clsid")]
#if NET48
        public string CLSID;
#else
        public string? CLSID;
#endif

        [XmlAttribute("progid")]
#if NET48
        public string ProgID;
#else
        public string? ProgID;
#endif

        [XmlAttribute("tlbid")]
#if NET48
        public string TLBID;
#else
        public string? TLBID;
#endif

        [XmlAttribute("description")]
#if NET48
        public string Description;
#else
        public string? Description;
#endif

        [XmlAttribute("runtimeVersion")]
#if NET48
        public string RuntimeVersion;
#else
        public string? RuntimeVersion;
#endif

        [XmlAttribute("threadingModel")]
#if NET48
        public string ThreadingModel;
#else
        public string? ThreadingModel;
#endif

        [XmlElement("progid")]
#if NET48
        public AssemblyProgID[] ProgIDs;
#else
        public AssemblyProgID[]? ProgIDs;
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyCommonLanguageSurrogateClass
    {
        [XmlAttribute("clsid")]
#if NET48
        public string CLSID;
#else
        public string? CLSID;
#endif

        [XmlAttribute("name")]
#if NET48
        public string Name;
#else
        public string? Name;
#endif

        [XmlAttribute("runtimeVersion")]
#if NET48
        public string RuntimeVersion;
#else
        public string? RuntimeVersion;
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyDependency
    {
        [XmlElement("dependentAssembly")]
#if NET48
        public AssemblyDependentAssembly DependentAssembly;
#else
        public AssemblyDependentAssembly? DependentAssembly;
#endif

        [XmlAttribute("optional")]
#if NET48
        public string Optional;
#else
        public string? Optional;
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyDependentAssembly
    {
        [XmlElement("assemblyIdentity")]
#if NET48
        public AssemblyIdentity AssemblyIdentity;
#else
        public AssemblyIdentity? AssemblyIdentity;
#endif

        [XmlElement("bindingRedirect")]
#if NET48
        public AssemblyBindingRedirect[] BindingRedirect;
#else
        public AssemblyBindingRedirect[]? BindingRedirect;
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyDescription
    {
        [XmlText]
#if NET48
        public string Value;
#else
        public string? Value;
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyDisableTheming
    {
        [XmlText]
#if NET48
        public string Value;
#else
        public string? Value;
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyDisableWindowFiltering
    {
        [XmlText]
#if NET48
        public string Value;
#else
        public string? Value;
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyDPIAware
    {
        [XmlText]
#if NET48
        public string Value;
#else
        public string? Value;
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyDPIAwareness
    {
        [XmlText]
#if NET48
        public string Value;
#else
        public string? Value;
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyFile
    {
        [XmlAttribute("name")]
#if NET48
        public string Name;
#else
        public string? Name;
#endif

        [XmlAttribute("hash")]
#if NET48
        public string Hash;
#else
        public string? Hash;
#endif

        [XmlAttribute("hashalg")]
#if NET48
        public string HashAlgorithm;
#else
        public string? HashAlgorithm;
#endif

        [XmlAttribute("size")]
#if NET48
        public string Size;
#else
        public string? Size;
#endif

        #region Group

        [XmlElement("comClass")]
#if NET48
        public AssemblyCOMClass[] COMClass;
#else
        public AssemblyCOMClass[]? COMClass;
#endif

        [XmlElement("comInterfaceProxyStub")]
#if NET48
        public AssemblyCOMInterfaceProxyStub[] COMInterfaceProxyStub;
#else
        public AssemblyCOMInterfaceProxyStub[]? COMInterfaceProxyStub;
#endif

        [XmlElement("typelib")]
#if NET48
        public AssemblyTypeLib[] Typelib;
#else
        public AssemblyTypeLib[]? Typelib;
#endif

        [XmlElement("windowClass")]
#if NET48
        public AssemblyWindowClass[] WindowClass;
#else
        public AssemblyWindowClass[]? WindowClass;
#endif

        #endregion
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyGDIScaling
    {
        [XmlText]
#if NET48
        public string Value;
#else
        public string? Value;
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyHeapType
    {
        [XmlText]
#if NET48
        public string Value;
#else
        public string? Value;
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyHighResolutionScrollingAware
    {
        [XmlText]
#if NET48
        public string Value;
#else
        public string? Value;
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyIdentity
    {
        [XmlAttribute("name")]
#if NET48
        public string Name;
#else
        public string? Name;
#endif

        [XmlAttribute("version")]
#if NET48
        public string Version;
#else
        public string? Version;
#endif

        [XmlAttribute("type")]
#if NET48
        public string Type;
#else
        public string? Type;
#endif

        [XmlAttribute("processorArchitecture")]
#if NET48
        public string ProcessorArchitecture;
#else
        public string? ProcessorArchitecture;
#endif

        [XmlAttribute("publicKeyToken")]
#if NET48
        public string PublicKeyToken;
#else
        public string? PublicKeyToken;
#endif

        [XmlAttribute("language")]
#if NET48
        public string Language;
#else
        public string? Language;
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyLongPathAware
    {
        [XmlText]
#if NET48
        public string Value;
#else
        public string? Value;
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
        public string Value;
#else
        public string? Value;
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyProgID
    {
        [XmlText]
#if NET48
        public string Value;
#else
        public string? Value;
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblySupportedOS
    {
        [XmlAttribute("Id")]
#if NET48
        public string Id;
#else
        public string? Id;
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyTypeLib
    {
        [XmlElement("tlbid")]
#if NET48
        public string TLBID;
#else
        public string? TLBID;
#endif

        [XmlElement("version")]
#if NET48
        public string Version;
#else
        public string? Version;
#endif

        [XmlElement("helpdir")]
#if NET48
        public string HelpDir;
#else
        public string? HelpDir;
#endif

        [XmlElement("resourceid")]
#if NET48
        public string ResourceID;
#else
        public string? ResourceID;
#endif

        [XmlElement("flags")]
#if NET48
        public string Flags;
#else
        public string? Flags;
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyUltraHighResolutionScrollingAware
    {
        [XmlText]
#if NET48
        public string Value;
#else
        public string? Value;
#endif
    }

    /// <see href="https://learn.microsoft.com/en-us/windows/win32/sbscs/manifest-file-schema"/>
    public sealed class AssemblyWindowClass
    {
        [XmlAttribute("versioned")]
#if NET48
        public string Versioned;
#else
        public string? Versioned;
#endif

        [XmlText]
#if NET48
        public string Value;
#else
        public string? Value;
#endif
    }

    // TODO: Left off at <ElementType name="progid" />
}
