﻿using System.ComponentModel.DataAnnotations;
using Casper.Domain.Features.Pages;
using CroquetAustralia.Library.Infrastructure;
using CroquetAustralia.Website.App.Infrastructure;

namespace CroquetAustralia.Website.App.admin.home
{
    public class EditPageViewModel : AdminViewModel
    {
        private string _content;

        // ReSharper disable once SuggestBaseTypeForParameter
        public EditPageViewModel(Page page)
        {
            Content = page.Content;
            RelativeUri = page.RelativeUri;
        }

        public string RelativeUri { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Content is required.")]
        public string Content
        {
            get { return _content ?? ""; }
            set { _content = value.AsTrimmedString(); }
        }
    }
}