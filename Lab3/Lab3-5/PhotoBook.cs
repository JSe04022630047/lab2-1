using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_5
{
    class PhotoBook
    {

        public PhotoBook()
        {
            Name = "Album01";
            Owner = "Mr. Photo";
            _nNumPages = 16;
        }

        public PhotoBook(int nNumPages=16)
        {
            Name = "Album01";
            Owner = "Mr. Photo";
            if (nNumPages > 0)
            { _nNumPages = (uint)nNumPages; }
            else { _nNumPages = 16; }
        }

        public PhotoBook(string name, string owner, int nNumPages=16) 
        {
            Name = name;
            Owner = owner;
            if (nNumPages > 0)
            { _nNumPages = (uint)nNumPages; }
            else { _nNumPages = 16; }
        }

        public int AddPages(int nNumPages)
        {
            if ( ((int)_nNumPages + nNumPages) <= 0 ) // imagine trying to read this
            {
                return (int)_nNumPages;
            }
            _nNumPages = (uint)(_nNumPages + nNumPages);
            return (int)_nNumPages; // instruction said to RETURN THE NEW PAGE so here it is. doesn't mention if the argument can be negative though.
        }

        private string _sName;
        public string Name 
        {
            get
            {
                return _sName;
            }
            set
            {
                _sName = value;
            }
        }
        private string _sOwner;
        public string Owner
        { 
            get
            {
                return _sOwner;
            }
            set
            {
                _sOwner = value;
            }
        }
        private uint _nNumPages; // can't be lower than 0
        public int NumPages
        {
            get
            {
                return (int)_nNumPages;
            }
        }
    }
}
