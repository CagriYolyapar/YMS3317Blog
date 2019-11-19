using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.RepositoryPattern.IntRepository
{
    public interface IRepository<T> where T:BaseEntity
    {
        //Listeleme metotlarım

        List<T> SelectActives();

        List<T> SelectPassives();

        List<T> SelectAll();

        List<T> SelectModifieds();

        List<T> OrderByDate();

        List<T> ReverseOrderByDate();

        //Commands(Emirler)

        void Add(T item);

        void Delete(T item);

        void Update(T item);

        void Destroy(T item);

        //Sorgulamalar(Queries)

        List<T> Where(Expression<Func<T,bool>> exp);

        bool Any(Expression<Func<T, bool>> exp);

        object Select(Expression<Func<T, object>> exp);

        T Find(int id);


    }
}
