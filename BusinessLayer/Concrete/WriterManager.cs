using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        private IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void Delete(Writer writer)
        {
            _writerDal.Delete(writer);
        }

        public Writer GetById(int id)
        {
            return _writerDal.Get(w => w.WriterId == id);
        }

        public List<Writer> GetList()
        {
            return _writerDal.List();
        }

        public void Update(Writer writer)
        {
            _writerDal.Update(writer);
        }

        public void Add(Writer writer)
        {
            _writerDal.Insert(writer);
        }
    }
}
