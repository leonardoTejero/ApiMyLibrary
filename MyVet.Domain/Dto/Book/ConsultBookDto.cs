using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Domain.Dto.Book
{
    public class ConsultBookDto : BookDto
    {
        public string Editorial { get; set; }
        public string Estado { get; set; }

    }
}
