using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Datos
{
    class ModelCourse : ModelDataBaseObject 
    {
        private int _courseId;
        private String _courseName;
        
        public int courseId 
        {
            get
            {
                return _courseId;
            }
            set
            {
                _courseId = value;
            }
        } 
        public String courseName
        {
            get
            {
                return _courseName;
            }
            set
            {
                _courseName = value;
            }
        }
    }
}
