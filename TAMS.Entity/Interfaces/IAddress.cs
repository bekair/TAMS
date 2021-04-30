using System.ComponentModel.DataAnnotations;
using TAMS.Common.Enums;

namespace TAMS.Entity.Interfaces
{
    public interface IAddress
    {
        AddressType AddressType { get; set; }
        string AddressName { get; set; }
        string AddressLine { get; set; }
    }
}