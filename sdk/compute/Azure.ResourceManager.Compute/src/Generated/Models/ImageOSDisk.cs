// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes an Operating System disk. </summary>
    public partial class ImageOSDisk : ImageDisk
    {
        /// <summary> Initializes a new instance of ImageOSDisk. </summary>
        /// <param name="osType"> This property allows you to specify the type of the OS that is included in the disk if creating a VM from a custom image. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Windows** &lt;br&gt;&lt;br&gt; **Linux**. </param>
        /// <param name="osState"> The OS State. </param>
        public ImageOSDisk(OperatingSystemTypes osType, OperatingSystemStateTypes osState)
        {
            OsType = osType;
            OsState = osState;
        }

        /// <summary> Initializes a new instance of ImageOSDisk. </summary>
        /// <param name="snapshot"> The snapshot. </param>
        /// <param name="managedDisk"> The managedDisk. </param>
        /// <param name="blobUri"> The Virtual Hard Disk. </param>
        /// <param name="caching"> Specifies the caching requirements. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **None** &lt;br&gt;&lt;br&gt; **ReadOnly** &lt;br&gt;&lt;br&gt; **ReadWrite** &lt;br&gt;&lt;br&gt; Default: **None for Standard storage. ReadOnly for Premium storage**. </param>
        /// <param name="diskSizeGB"> Specifies the size of empty data disks in gigabytes. This element can be used to overwrite the name of the disk in a virtual machine image. &lt;br&gt;&lt;br&gt; This value cannot be larger than 1023 GB. </param>
        /// <param name="storageAccountType"> Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with data disks, it cannot be used with OS Disk. </param>
        /// <param name="diskEncryptionSet"> Specifies the customer managed disk encryption set resource id for the managed image disk. </param>
        /// <param name="osType"> This property allows you to specify the type of the OS that is included in the disk if creating a VM from a custom image. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Windows** &lt;br&gt;&lt;br&gt; **Linux**. </param>
        /// <param name="osState"> The OS State. </param>
        internal ImageOSDisk(SubResource snapshot, SubResource managedDisk, string blobUri, CachingTypes? caching, int? diskSizeGB, StorageAccountTypes? storageAccountType, SubResource diskEncryptionSet, OperatingSystemTypes osType, OperatingSystemStateTypes osState) : base(snapshot, managedDisk, blobUri, caching, diskSizeGB, storageAccountType, diskEncryptionSet)
        {
            OsType = osType;
            OsState = osState;
        }

        /// <summary> This property allows you to specify the type of the OS that is included in the disk if creating a VM from a custom image. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Windows** &lt;br&gt;&lt;br&gt; **Linux**. </summary>
        public OperatingSystemTypes OsType { get; set; }
        /// <summary> The OS State. </summary>
        public OperatingSystemStateTypes OsState { get; set; }
    }
}
