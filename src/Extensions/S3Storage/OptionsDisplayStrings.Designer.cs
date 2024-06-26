﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Diagnostics.Monitoring.Extension.S3Storage {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class OptionsDisplayStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal OptionsDisplayStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Diagnostics.Monitoring.Extension.S3Storage.OptionsDisplayStrings", typeof(OptionsDisplayStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Buffer size used when copying data from an egress callback returning a stream to the egress callback that is provided a stream to which data is written..
        /// </summary>
        public static string DisplayAttributeDescription_CommonEgressProviderOptions_CopyBufferSize {
            get {
                return ResourceManager.GetString("DisplayAttributeDescription_CommonEgressProviderOptions_CopyBufferSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The AWS AccessKeyId for IAM user to login.
        /// </summary>
        public static string DisplayAttributeDescription_S3StorageEgressProviderOptions_AccessKeyId {
            get {
                return ResourceManager.GetString("DisplayAttributeDescription_S3StorageEgressProviderOptions_AccessKeyId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The AWS profile name to be used for login.
        /// </summary>
        public static string DisplayAttributeDescription_S3StorageEgressProviderOptions_AWSProfileName {
            get {
                return ResourceManager.GetString("DisplayAttributeDescription_S3StorageEgressProviderOptions_AWSProfileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The AWS profile path, if profile details not stored in default path.
        /// </summary>
        public static string DisplayAttributeDescription_S3StorageEgressProviderOptions_AWSProfilePath {
            get {
                return ResourceManager.GetString("DisplayAttributeDescription_S3StorageEgressProviderOptions_AWSProfilePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of the bucket used for storage.
        /// </summary>
        public static string DisplayAttributeDescription_S3StorageEgressProviderOptions_BucketName {
            get {
                return ResourceManager.GetString("DisplayAttributeDescription_S3StorageEgressProviderOptions_BucketName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The endpoint of S3 to connect to. This is optional in case of using AWS storage..
        /// </summary>
        public static string DisplayAttributeDescription_S3StorageEgressProviderOptions_Endpoint {
            get {
                return ResourceManager.GetString("DisplayAttributeDescription_S3StorageEgressProviderOptions_Endpoint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The boolean flag set for AWS connection configuration ForcePathStyle option..
        /// </summary>
        public static string DisplayAttributeDescription_S3StorageEgressProviderOptions_ForcePathStyle {
            get {
                return ResourceManager.GetString("DisplayAttributeDescription_S3StorageEgressProviderOptions_ForcePathStyle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A boolean flag indicates if the return value of egress provider should be a pre-signed URL or only the bucket name and object id of uploaded entry..
        /// </summary>
        public static string DisplayAttributeDescription_S3StorageEgressProviderOptions_GeneratePreSignedUrl {
            get {
                return ResourceManager.GetString("DisplayAttributeDescription_S3StorageEgressProviderOptions_GeneratePreSignedUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If UseKmsEncryption is true, this specifies the arn of the &quot;customer managed&quot; KMS encryption key to be used for server side encryption. If no value is set for this field then S3 will use an AWS managed key for KMS encryption.
        /// </summary>
        public static string DisplayAttributeDescription_S3StorageEgressProviderOptions_KmsEncryptionKey {
            get {
                return ResourceManager.GetString("DisplayAttributeDescription_S3StorageEgressProviderOptions_KmsEncryptionKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The amount of time the generated pre-signed url will be accessible..
        /// </summary>
        public static string DisplayAttributeDescription_S3StorageEgressProviderOptions_PreSignedUrlExpiry {
            get {
                return ResourceManager.GetString("DisplayAttributeDescription_S3StorageEgressProviderOptions_PreSignedUrlExpiry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of the S3 region.
        /// </summary>
        public static string DisplayAttributeDescription_S3StorageEgressProviderOptions_RegionName {
            get {
                return ResourceManager.GetString("DisplayAttributeDescription_S3StorageEgressProviderOptions_RegionName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The AWS SecretAccessKey associated AccessKeyId for IAM user to login.
        /// </summary>
        public static string DisplayAttributeDescription_S3StorageEgressProviderOptions_SecretAccessKey {
            get {
                return ResourceManager.GetString("DisplayAttributeDescription_S3StorageEgressProviderOptions_SecretAccessKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A boolean flag which controls whether the Egress should use KMS server side encryption..
        /// </summary>
        public static string DisplayAttributeDescription_S3StorageEgressProviderOptions_UseKmsEncryption {
            get {
                return ResourceManager.GetString("DisplayAttributeDescription_S3StorageEgressProviderOptions_UseKmsEncryption", resourceCulture);
            }
        }
    }
}
