﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer.Concrete {
    public class CategoryManager : ICategoryService {

        ICategoryDAL _categoryDal;

        public CategoryManager(ICategoryDAL categoryDal) {
            _categoryDal = categoryDal;
        }

        public void CategoryAddBL(Category category) {
            _categoryDal.Insert(category);
        }

        public void CategoryDelete(Category category) {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category) {
            _categoryDal.Update(category);
        }

        public List<Category> GetAllBL() {
            return _categoryDal.List();
        }

        public Category GetByID(int id) {
            return _categoryDal.Get(x => x.CategoryID == id);
        }

        public List<Category> GetList() {
            return _categoryDal.List();
        }

        //public void CategoryAddBL(Category p) {
        //    if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDescription == "" ||
        //        p.CategoryStatus == false || p.CategoryName.Length > 51) {
        //        //hata mesajı
        //    }
        //    else {
        //        _categoryDal.Insert(p);
        //    }
        //}
    }
}
