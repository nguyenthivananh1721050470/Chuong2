using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chuong2.Models
{
    public class AutogenerateKey
    {
        public string GenerateKey(string id)
        {
            // kiểm tra giá trị id truyền vào là lỗi hay không
            string strkey = "";
            // nếu mà id không lỗi thì tách riêng phần soos và tham số id
            string thamso = id.Substring(0, 2);
            string maso = id.Substring(2);
            int masomoi = Int32.Parse(maso) + 1;
            // giữ nguyễn phẫn chữ
            strkey = thamso + masomoi;
            // phần số chuyển đổi sang kiểu số nguyên và tawg lên 1 đơn vị
            // ghép phần số với phần chữ để đc mã tự sinh
            // trả về mã sau khi tự sinh
            return strkey;
        }
    }
}