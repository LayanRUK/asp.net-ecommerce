using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Newtonsoft.Json.Converters;

namespace sda_onsite_2_csharp_backend_teamwork.src.Enums;

public enum Role
{
    Customer,

    Admin
}
