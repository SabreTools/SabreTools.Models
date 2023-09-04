using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.ArchiveDotOrg
{
    [XmlRoot("file")]
    public class File
    {
        [XmlAttribute("name")]
#if NET48
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        /// <remarks>Is this a set of defined values?</remarks>
        [XmlAttribute("source")]
#if NET48
        public string Source { get; set; }
#else
        public string? Source { get; set; }
#endif

        [XmlElement("btih")]
#if NET48
        public string BitTorrentMagnetHash { get; set; }
#else
        public string? BitTorrentMagnetHash { get; set; }
#endif

        [XmlElement("mtime")]
#if NET48
        public string LastModifiedTime { get; set; }
#else
        public string? LastModifiedTime { get; set; }
#endif

        [XmlElement("size")]
#if NET48
        public string Size { get; set; }
#else
        public string? Size { get; set; }
#endif

        [XmlElement("md5")]
#if NET48
        public string MD5 { get; set; }
#else
        public string? MD5 { get; set; }
#endif

        [XmlElement("crc32")]
#if NET48
        public string CRC32 { get; set; }
#else
        public string? CRC32 { get; set; }
#endif

        [XmlElement("sha1")]
#if NET48
        public string SHA1 { get; set; }
#else
        public string? SHA1 { get; set; }
#endif

        [XmlElement("filecount")]
#if NET48
        public string FileCount { get; set; }
#else
        public string? FileCount { get; set; }
#endif

        /// <remarks>Is this a set of defined values?</remarks>
        [XmlElement("format")]
#if NET48
        public string Format { get; set; }
#else
        public string? Format { get; set; }
#endif

        [XmlElement("original")]
#if NET48
        public string Original { get; set; }
#else
        public string? Original { get; set; }
#endif

        /// <remarks>Is this a set of defined values?</remarks>
        [XmlElement("summation")]
#if NET48
        public string Summation { get; set; }
#else
        public string? Summation { get; set; }
#endif

        [XmlElement("matrix_number")]
#if NET48
        public string MatrixNumber { get; set; }
#else
        public string? MatrixNumber { get; set; }
#endif

        [XmlElement("collection-catalog-number")]
#if NET48
        public string CollectionCatalogNumber { get; set; }
#else
        public string? CollectionCatalogNumber { get; set; }
#endif

        [XmlElement("publisher")]
#if NET48
        public string Publisher { get; set; }
#else
        public string? Publisher { get; set; }
#endif

        [XmlElement("comment")]
#if NET48
        public string Comment { get; set; }
#else
        public string? Comment { get; set; }
#endif

        #region ASR-Related

        [XmlElement("asr_detected_lang")]
#if NET48
        public string ASRDetectedLang { get; set; }
#else
        public string? ASRDetectedLang { get; set; }
#endif

        [XmlElement("asr_detected_lang_conf")]
#if NET48
        public string ASRDetectedLangConf { get; set; }
#else
        public string? ASRDetectedLangConf { get; set; }
#endif

        [XmlElement("asr_transcribed_lang")]
#if NET48
        public string ASRTranscribedLang { get; set; }
#else
        public string? ASRTranscribedLang { get; set; }
#endif

        [XmlElement("whisper_asr_module_version")]
#if NET48
        public string WhisperASRModuleVersion { get; set; }
#else
        public string? WhisperASRModuleVersion { get; set; }
#endif

        [XmlElement("whisper_model_hash")]
#if NET48
        public string WhisperModelHash { get; set; }
#else
        public string? WhisperModelHash { get; set; }
#endif

        [XmlElement("whisper_model_name")]
#if NET48
        public string WhisperModelName { get; set; }
#else
        public string? WhisperModelName { get; set; }
#endif

        [XmlElement("whisper_version")]
#if NET48
        public string WhisperVersion { get; set; }
#else
        public string? WhisperVersion { get; set; }
#endif

        #endregion

        #region OCR-Related

        [XmlElement("cloth_cover_detection_module_version")]
#if NET48
        public string ClothCoverDetectionModuleVersion { get; set; }
#else
        public string? ClothCoverDetectionModuleVersion { get; set; }
#endif

        [XmlElement("hocr_char_to_word_hocr_version")]
#if NET48
        public string hOCRCharToWordhOCRVersion { get; set; }
#else
        public string? hOCRCharToWordhOCRVersion { get; set; }
#endif

        [XmlElement("hocr_char_to_word_module_version")]
#if NET48
        public string hOCRCharToWordModuleVersion { get; set; }
#else
        public string? hOCRCharToWordModuleVersion { get; set; }
#endif

        [XmlElement("hocr_fts_text_hocr_version")]
#if NET48
        public string hOCRFtsTexthOCRVersion { get; set; }
#else
        public string? hOCRFtsTexthOCRVersion { get; set; }
#endif

        [XmlElement("hocr_fts_text_module_version")]
#if NET48
        public string hOCRFtsTextModuleVersion { get; set; }
#else
        public string? hOCRFtsTextModuleVersion { get; set; }
#endif

        [XmlElement("hocr_pageindex_hocr_version")]
#if NET48
        public string hOCRPageIndexhOCRVersion { get; set; }
#else
        public string? hOCRPageIndexhOCRVersion { get; set; }
#endif

        [XmlElement("hocr_pageindex_module_version")]
#if NET48
        public string hOCRPageIndexModuleVersion { get; set; }
#else
        public string? hOCRPageIndexModuleVersion { get; set; }
#endif

        [XmlElement("ocr")]
#if NET48
        public string TesseractOCR { get; set; }
#else
        public string? TesseractOCR { get; set; }
#endif

        [XmlElement("ocr_converted")]
#if NET48
        public string TesseractOCRConverted { get; set; }
#else
        public string? TesseractOCRConverted { get; set; }
#endif

        [XmlElement("ocr_detected_lang")]
#if NET48
        public string TesseractOCRDetectedLang { get; set; }
#else
        public string? TesseractOCRDetectedLang { get; set; }
#endif

        [XmlElement("ocr_detected_lang_conf")]
#if NET48
        public string TesseractOCRDetectedLangConf { get; set; }
#else
        public string? TesseractOCRDetectedLangConf { get; set; }
#endif

        [XmlElement("ocr_detected_script")]
#if NET48
        public string TesseractOCRDetectedScript { get; set; }
#else
        public string? TesseractOCRDetectedScript { get; set; }
#endif

        [XmlElement("ocr_detected_script_conf")]
#if NET48
        public string TesseractOCRDetectedScriptConf { get; set; }
#else
        public string? TesseractOCRDetectedScriptConf { get; set; }
#endif

        [XmlElement("ocr_module_version")]
#if NET48
        public string TesseractOCRModuleVersion { get; set; }
#else
        public string? TesseractOCRModuleVersion { get; set; }
#endif

        [XmlElement("ocr_parameters")]
#if NET48
        public string TesseractOCRParameters { get; set; }
#else
        public string? TesseractOCRParameters { get; set; }
#endif

        [XmlElement("pdf_module_version")]
#if NET48
        public string PDFModuleVersion { get; set; }
#else
        public string? PDFModuleVersion { get; set; }
#endif

        [XmlElement("word_conf_0_10")]
#if NET48
        public string WordConfidenceInterval0To10 { get; set; }
#else
        public string? WordConfidenceInterval0To10 { get; set; }
#endif

        [XmlElement("word_conf_11_20")]
#if NET48
        public string WordConfidenceInterval11To20 { get; set; }
#else
        public string? WordConfidenceInterval11To20 { get; set; }
#endif

        [XmlElement("word_conf_21_30")]
#if NET48
        public string WordConfidenceInterval21To30 { get; set; }
#else
        public string? WordConfidenceInterval21To30 { get; set; }
#endif

        [XmlElement("word_conf_31_40")]
#if NET48
        public string WordConfidenceInterval31To40 { get; set; }
#else
        public string? WordConfidenceInterval31To40 { get; set; }
#endif

        [XmlElement("word_conf_41_50")]
#if NET48
        public string WordConfidenceInterval41To50 { get; set; }
#else
        public string? WordConfidenceInterval41To50 { get; set; }
#endif

        [XmlElement("word_conf_51_60")]
#if NET48
        public string WordConfidenceInterval51To60 { get; set; }
#else
        public string? WordConfidenceInterval51To60 { get; set; }
#endif

        [XmlElement("word_conf_61_70")]
#if NET48
        public string WordConfidenceInterval61To70 { get; set; }
#else
        public string? WordConfidenceInterval61To70 { get; set; }
#endif

        [XmlElement("word_conf_71_80")]
#if NET48
        public string WordConfidenceInterval71To80 { get; set; }
#else
        public string? WordConfidenceInterval71To80 { get; set; }
#endif

        [XmlElement("word_conf_81_90")]
#if NET48
        public string WordConfidenceInterval81To90 { get; set; }
#else
        public string? WordConfidenceInterval81To90 { get; set; }
#endif

        [XmlElement("word_conf_91_100")]
#if NET48
        public string WordConfidenceInterval91To100 { get; set; }
#else
        public string? WordConfidenceInterval91To100 { get; set; }
#endif

        #endregion

        #region Media-Related

        [XmlElement("album")]
#if NET48
        public string Album { get; set; }
#else
        public string? Album { get; set; }
#endif

        [XmlElement("artist")]
#if NET48
        public string Artist { get; set; }
#else
        public string? Artist { get; set; }
#endif

        [XmlElement("bitrate")]
#if NET48
        public string Bitrate { get; set; }
#else
        public string? Bitrate { get; set; }
#endif

        [XmlElement("creator")]
#if NET48
        public string Creator { get; set; }
#else
        public string? Creator { get; set; }
#endif

        [XmlElement("height")]
#if NET48
        public string Height { get; set; }
#else
        public string? Height { get; set; }
#endif

        [XmlElement("length")]
#if NET48
        public string Length { get; set; }
#else
        public string? Length { get; set; }
#endif

        [XmlElement("preview-image")]
#if NET48
        public string PreviewImage { get; set; }
#else
        public string? PreviewImage { get; set; }
#endif

        /// <remarks>Is this a set of defined values?</remarks>
        [XmlElement("rotation")]
#if NET48
        public string Rotation { get; set; }
#else
        public string? Rotation { get; set; }
#endif

        [XmlElement("title")]
#if NET48
        public string Title { get; set; }
#else
        public string? Title { get; set; }
#endif

        [XmlElement("track")]
#if NET48
        public string Track { get; set; }
#else
        public string? Track { get; set; }
#endif

        [XmlElement("width")]
#if NET48
        public string Width { get; set; }
#else
        public string? Width { get; set; }
#endif

        #endregion

        #region DO NOT USE IN PRODUCTION

        /// <remarks>Should be empty</remarks>
        [XmlAnyAttribute]
#if NET48
        public XmlAttribute[] ADDITIONAL_ATTRIBUTES { get; set; }
#else
        public XmlAttribute[]? ADDITIONAL_ATTRIBUTES { get; set; }
#endif

        /// <remarks>Should be empty</remarks>
        [XmlAnyElement]
#if NET48
        public object[] ADDITIONAL_ELEMENTS { get; set; }
#else
        public object[]? ADDITIONAL_ELEMENTS { get; set; }
#endif

        #endregion
    }
}