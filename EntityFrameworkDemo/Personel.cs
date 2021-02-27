using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    //Database ve Class adları uyum içinde olmazsa Custom mapping yapılmalıdır. Burada Custom mapping örneği görülecektir.
    public class Personel
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }


    }
}
