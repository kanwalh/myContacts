// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.7
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myContacts.EntityModel.Entities
{

    // People
    [Table("People", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"ContactId", Order = 1, TypeName = "uniqueidentifier")]
        [Index(@"PK_ContactId", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Contact ID")]
        public System.Guid ContactId { get; set; } // ContactId (Primary key)

        [Column(@"Title", Order = 2, TypeName = "varchar")]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Title")]
        public string Title { get; set; } // Title (length: 20)

        [Column(@"NamePrefix", Order = 3, TypeName = "varchar")]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Name prefix")]
        public string NamePrefix { get; set; } // NamePrefix (length: 20)

        [Column(@"FirstName", Order = 4, TypeName = "varchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "First name")]
        public string FirstName { get; set; } // FirstName (length: 100)

        [Column(@"MiddleName", Order = 5, TypeName = "varchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Middle name")]
        public string MiddleName { get; set; } // MiddleName (length: 100)

        [Column(@"LastName", Order = 6, TypeName = "varchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Last name")]
        public string LastName { get; set; } // LastName (length: 100)

        [Column(@"NameSuffix", Order = 7, TypeName = "varchar")]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Name suffix")]
        public string NameSuffix { get; set; } // NameSuffix (length: 20)

        [Column(@"NickName", Order = 8, TypeName = "varchar")]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Nick name")]
        public string NickName { get; set; } // NickName (length: 20)
    }

}
// </auto-generated>
