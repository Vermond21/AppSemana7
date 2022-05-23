using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace AppSemana7
{
    public interface DataBase
    {
        SQLiteAsyncConnection GetConnection();
    }
}
