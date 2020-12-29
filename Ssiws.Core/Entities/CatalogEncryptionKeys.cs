using RepoDb.Attributes;
using System;
using Ssiws.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[catalog_encryption_keys]")]    
    [ControllerDetails("api/SSISDB/CatalogEncryptionKeys")]    
    public class CatalogEncryptionKeys
    {
        [Key]
        [Map("[key_id]")]         
        public long KeyId { get; set; }
        
        [Map("[key_name]")]         
        public string KeyName { get; set; }
        
        [Map("[KEY]")]         
        public byte[] Key { get; set; }
        
        [Map("[IV]")]         
        public byte[] Iv { get; set; }
    }
}
