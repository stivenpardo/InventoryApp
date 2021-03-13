using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class WareHouseEntity
    {
        [Key]
        [StringLength(50)]
        public string WarehouseId { get; set; }
        
        [Required]
        [StringLength(100)]
        public string WarehouseName { get; set; }

        [Required]
        [StringLength(100)]
        public string WarehouseAdress { get; set; }

        public ICollection<StorageEntity> Storages { get; set; }
    }
}
