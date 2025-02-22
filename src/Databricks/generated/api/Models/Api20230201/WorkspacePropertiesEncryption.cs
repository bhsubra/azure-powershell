// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Extensions;

    /// <summary>Encryption properties for databricks workspace</summary>
    public partial class WorkspacePropertiesEncryption :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IWorkspacePropertiesEncryption,
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IWorkspacePropertiesEncryptionInternal
    {

        /// <summary>Backing field for <see cref="Entity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinition _entity;

        /// <summary>Encryption entities definition for the workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinition Entity { get => (this._entity = this._entity ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.EncryptionEntitiesDefinition()); set => this._entity = value; }

        /// <summary>
        /// The encryption keySource (provider). Possible values (case-insensitive): Microsoft.Keyvault
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string ManagedDiskKeySource { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedDiskKeySource; }

        /// <summary>The name of KeyVault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string ManagedDiskKeyVaultPropertiesKeyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedDiskKeyVaultPropertiesKeyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedDiskKeyVaultPropertiesKeyName = value ?? null; }

        /// <summary>The URI of KeyVault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string ManagedDiskKeyVaultPropertiesKeyVaultUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedDiskKeyVaultPropertiesKeyVaultUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedDiskKeyVaultPropertiesKeyVaultUri = value ?? null; }

        /// <summary>The version of KeyVault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string ManagedDiskKeyVaultPropertiesKeyVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedDiskKeyVaultPropertiesKeyVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedDiskKeyVaultPropertiesKeyVersion = value ?? null; }

        /// <summary>
        /// Indicate whether the latest key version should be automatically used for Managed Disk Encryption.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public bool? ManagedDiskRotationToLatestKeyVersionEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedDiskRotationToLatestKeyVersionEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedDiskRotationToLatestKeyVersionEnabled = value ?? default(bool); }

        /// <summary>
        /// The encryption keySource (provider). Possible values (case-insensitive): Microsoft.Keyvault
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string ManagedServiceKeySource { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedServiceKeySource; }

        /// <summary>The name of KeyVault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string ManagedServicesKeyVaultPropertiesKeyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedServicesKeyVaultPropertiesKeyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedServicesKeyVaultPropertiesKeyName = value ?? null; }

        /// <summary>The Uri of KeyVault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string ManagedServicesKeyVaultPropertiesKeyVaultUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedServicesKeyVaultPropertiesKeyVaultUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedServicesKeyVaultPropertiesKeyVaultUri = value ?? null; }

        /// <summary>The version of KeyVault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string ManagedServicesKeyVaultPropertiesKeyVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedServicesKeyVaultPropertiesKeyVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedServicesKeyVaultPropertiesKeyVersion = value ?? null; }

        /// <summary>Internal Acessors for Entity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinition Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IWorkspacePropertiesEncryptionInternal.Entity { get => (this._entity = this._entity ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.EncryptionEntitiesDefinition()); set { {_entity = value;} } }

        /// <summary>Internal Acessors for EntityManagedDisk</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IManagedDiskEncryption Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IWorkspacePropertiesEncryptionInternal.EntityManagedDisk { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedDisk; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedDisk = value; }

        /// <summary>Internal Acessors for EntityManagedService</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionV2 Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IWorkspacePropertiesEncryptionInternal.EntityManagedService { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedService; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedService = value; }

        /// <summary>Internal Acessors for ManagedDiskKeySource</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IWorkspacePropertiesEncryptionInternal.ManagedDiskKeySource { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedDiskKeySource; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedDiskKeySource = value; }

        /// <summary>Internal Acessors for ManagedDiskKeyVaultProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IManagedDiskEncryptionKeyVaultProperties Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IWorkspacePropertiesEncryptionInternal.ManagedDiskKeyVaultProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedDiskKeyVaultProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedDiskKeyVaultProperty = value; }

        /// <summary>Internal Acessors for ManagedServiceKeySource</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IWorkspacePropertiesEncryptionInternal.ManagedServiceKeySource { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedServiceKeySource; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedServiceKeySource = value; }

        /// <summary>Internal Acessors for ManagedServiceKeyVaultProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionV2KeyVaultProperties Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IWorkspacePropertiesEncryptionInternal.ManagedServiceKeyVaultProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedServiceKeyVaultProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinitionInternal)Entity).ManagedServiceKeyVaultProperty = value; }

        /// <summary>Creates an new <see cref="WorkspacePropertiesEncryption" /> instance.</summary>
        public WorkspacePropertiesEncryption()
        {

        }
    }
    /// Encryption properties for databricks workspace
    public partial interface IWorkspacePropertiesEncryption :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The encryption keySource (provider). Possible values (case-insensitive): Microsoft.Keyvault
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Keyvault",
        SerializedName = @"keySource",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedDiskKeySource { get;  }
        /// <summary>The name of KeyVault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of KeyVault key.",
        SerializedName = @"keyName",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedDiskKeyVaultPropertiesKeyName { get; set; }
        /// <summary>The URI of KeyVault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URI of KeyVault.",
        SerializedName = @"keyVaultUri",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedDiskKeyVaultPropertiesKeyVaultUri { get; set; }
        /// <summary>The version of KeyVault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of KeyVault key.",
        SerializedName = @"keyVersion",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedDiskKeyVaultPropertiesKeyVersion { get; set; }
        /// <summary>
        /// Indicate whether the latest key version should be automatically used for Managed Disk Encryption.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicate whether the latest key version should be automatically used for Managed Disk Encryption.",
        SerializedName = @"rotationToLatestKeyVersionEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ManagedDiskRotationToLatestKeyVersionEnabled { get; set; }
        /// <summary>
        /// The encryption keySource (provider). Possible values (case-insensitive): Microsoft.Keyvault
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Keyvault",
        SerializedName = @"keySource",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedServiceKeySource { get;  }
        /// <summary>The name of KeyVault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of KeyVault key.",
        SerializedName = @"keyName",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedServicesKeyVaultPropertiesKeyName { get; set; }
        /// <summary>The Uri of KeyVault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Uri of KeyVault.",
        SerializedName = @"keyVaultUri",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedServicesKeyVaultPropertiesKeyVaultUri { get; set; }
        /// <summary>The version of KeyVault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of KeyVault key.",
        SerializedName = @"keyVersion",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedServicesKeyVaultPropertiesKeyVersion { get; set; }

    }
    /// Encryption properties for databricks workspace
    internal partial interface IWorkspacePropertiesEncryptionInternal

    {
        /// <summary>Encryption entities definition for the workspace.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionEntitiesDefinition Entity { get; set; }
        /// <summary>Encryption properties for the databricks managed disks.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IManagedDiskEncryption EntityManagedDisk { get; set; }
        /// <summary>Encryption properties for the databricks managed services.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionV2 EntityManagedService { get; set; }
        /// <summary>
        /// The encryption keySource (provider). Possible values (case-insensitive): Microsoft.Keyvault
        /// </summary>
        string ManagedDiskKeySource { get; set; }
        /// <summary>The name of KeyVault key.</summary>
        string ManagedDiskKeyVaultPropertiesKeyName { get; set; }
        /// <summary>The URI of KeyVault.</summary>
        string ManagedDiskKeyVaultPropertiesKeyVaultUri { get; set; }
        /// <summary>The version of KeyVault key.</summary>
        string ManagedDiskKeyVaultPropertiesKeyVersion { get; set; }
        /// <summary>Key Vault input properties for encryption.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IManagedDiskEncryptionKeyVaultProperties ManagedDiskKeyVaultProperty { get; set; }
        /// <summary>
        /// Indicate whether the latest key version should be automatically used for Managed Disk Encryption.
        /// </summary>
        bool? ManagedDiskRotationToLatestKeyVersionEnabled { get; set; }
        /// <summary>
        /// The encryption keySource (provider). Possible values (case-insensitive): Microsoft.Keyvault
        /// </summary>
        string ManagedServiceKeySource { get; set; }
        /// <summary>Key Vault input properties for encryption.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IEncryptionV2KeyVaultProperties ManagedServiceKeyVaultProperty { get; set; }
        /// <summary>The name of KeyVault key.</summary>
        string ManagedServicesKeyVaultPropertiesKeyName { get; set; }
        /// <summary>The Uri of KeyVault.</summary>
        string ManagedServicesKeyVaultPropertiesKeyVaultUri { get; set; }
        /// <summary>The version of KeyVault key.</summary>
        string ManagedServicesKeyVaultPropertiesKeyVersion { get; set; }

    }
}