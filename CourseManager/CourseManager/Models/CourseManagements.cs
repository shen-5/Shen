//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class CourseManagements
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "班级")]
        public int ClassId { get; set; }
        [Required]
        [Display(Name = "课程")]
        public int CourseId { get; set; }
        [Required]
        [Display(Name = "班主任")]
        public int TeacherId { get; set; }
    }
}