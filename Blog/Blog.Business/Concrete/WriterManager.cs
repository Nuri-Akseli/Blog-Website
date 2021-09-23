using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Concrete
{
    public class WriterManager:IWriterService
    {
        private IWriterDal _writerDal;
        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public bool isEmailUnique(string email)
        {
            return _writerDal.Get(writer => writer.WriterMail == email) == null
                ? true
                : false;
        }
    }
}
