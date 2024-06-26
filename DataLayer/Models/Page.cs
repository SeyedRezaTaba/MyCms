﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Page
    {
        [Key]
        public int PageId { get; set; }


        [Display(Name ="گروه صفحه")]
        [Required(ErrorMessage ="لطفا {0} را وارد نمایید ")]
        public int GroupId { get; set; }


        [Display(Name = "عنوان صفحه")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید ")]
        [MaxLength(100)]
        public string Title { get; set; }


        [Display(Name = "توضیح مختصر")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید ")]
        [MaxLength(350)]
        [DataType(DataType.MultilineText)]
        public string ShortDescription { get; set; }


        [Display(Name = "متن صفحه")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید ")]
        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string Text { get; set; }


        [Display(Name = "تعداد بازدید صفحه")]        
        public int Visit { get; set; }

        [Display(Name = "عکس صفحه")]        
        public string ImageName { get; set; }


        [Display(Name = "نمایش در اسلایدر")]        
        public bool ShowInSlider { get; set; }


        [Display(Name = "تاریخ ایجاد")]        
        public DateTime CreaetDate { get; set; }

        [Display(Name = "کلمات کلیدی")]
        public string Tags { get; set; }


        //Navigation Property
        public virtual List<PageComment> PageComments { get; set; }
        public virtual PageGroup PageGroup { get; set; }
        public Page()
        {

        }

    }
}
