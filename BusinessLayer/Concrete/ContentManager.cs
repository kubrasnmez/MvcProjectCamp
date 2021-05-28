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
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public void Add(Content content)
        {
            _contentDal.Insert(content);
        }

        public void Delete(Content content)
        {
            _contentDal.Delete(content);
        }

        public List<Content> GetAll()
        {
            return _contentDal.List();
        }

        public Content GetById(int id)
        {
            return _contentDal.Get(c => c.ContentId == id);
        }

        public List<Content> GetListById(int id)
        {
            return _contentDal.List(c => c.HeadingId == id);
        }

        public void Update(Content content)
        {
            _contentDal.Update(content);
        }
    }
}
