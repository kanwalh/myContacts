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
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class PersonConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
            : this("dbo")
        {
        }

        public PersonConfiguration(string schema)
        {
            Property(x => x.Title).IsOptional().IsUnicode(false);
            Property(x => x.NamePrefix).IsOptional().IsUnicode(false);
            Property(x => x.FirstName).IsUnicode(false);
            Property(x => x.MiddleName).IsOptional().IsUnicode(false);
            Property(x => x.LastName).IsOptional().IsUnicode(false);
            Property(x => x.NameSuffix).IsOptional().IsUnicode(false);
            Property(x => x.NickName).IsOptional().IsUnicode(false);
        }
    }

}
// </auto-generated>
