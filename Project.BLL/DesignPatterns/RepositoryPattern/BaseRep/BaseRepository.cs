using Project.BLL.DesignPatterns.RepositoryPattern.IntRepository;
using Project.BLL.DesignPatterns.SingletonPattern;
using Project.DAL.Context;
using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.RepositoryPattern.BaseRep
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        MyContext db;

        public BaseRepository()
        {
            db = DBTool.DBInstance;
        }



        public void Add(T item)
        {
            db.Set<T>().Add(item);
            db.SaveChanges();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Any(exp);
        }

        public void Delete(T item)
        {
            item.Status = MODEL.Enums.DataStatus.Deleted;
            item.DeletedDate = DateTime.Now;
            db.SaveChanges();
        }

        public void Destroy(T item)
        {
            //dikkat burası veriyi gercekten siler!!
            db.Set<T>().Remove(item);
            db.SaveChanges();
        }

        public T Find(int id)
        {
            return db.Set<T>().Find(id);
        }

        public List<T> OrderByDate()
        {
            return db.Set<T>().OrderBy(x => x.CreatedDate).ToList();
        }

        public List<T> ReverseOrderByDate()
        {
            return db.Set<T>().OrderByDescending(x => x.CreatedDate).ToList();
        }

        public object Select(Expression<Func<T, object>> exp)
        {
            return db.Set<T>().Select(exp).ToList();
        }

        public List<T> SelectActives()
        {
            return db.Set<T>().Where(x => x.Status != MODEL.Enums.DataStatus.Deleted).ToList();
        }

        public List<T> SelectAll()
        {
            return db.Set<T>().ToList();
        }

        public List<T> SelectModifieds()
        {
            return db.Set<T>().Where(x => x.Status == MODEL.Enums.DataStatus.Updated).ToList();
        }

        public List<T> SelectPassives()
        {
            return db.Set<T>().Where(x => x.Status == MODEL.Enums.DataStatus.Deleted).ToList();
        }

        public void Update(T item)
        {
            item.Status = MODEL.Enums.DataStatus.Updated;
            item.ModifiedDate = DateTime.Now;
            T guncellenecek = Find(item.ID);
            db.Entry(guncellenecek).CurrentValues.SetValues(item);
            db.SaveChanges();


        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Where(exp).ToList();
        }
    }
}
