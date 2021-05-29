﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Add(Contact contact)
        {
            _contactDal.Insert(contact);
        }

        public void Delete(Contact contact)
        {
            _contactDal.Delete(contact);
        }

        public Contact GetById(int id)
        {
            return _contactDal.Get(c => c.ContactId == id);
        }

        public List<Contact> GetList()
        {
            return _contactDal.List();
        }

        public void Update(Contact contact)
        {
            _contactDal.Update(contact);
        }
    }
}
