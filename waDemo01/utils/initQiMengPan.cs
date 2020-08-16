using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  waDemo01.utils;

namespace waDemo01.utils
{
    class InitQiMengPan
    {

        //private DateTime datetime;
        public  Dictionary<String,String>   initQiMengPage(DateTime dt) {
            if (dt == null || dt.ToString().Equals(""))
            {
                throw new Exception("初始化奇门局失败！");
            }
            // DateTime dt = DateTime.Now.ToLocalTime();

            Dictionary<String, String> disc = new Dictionary<string, string>();
            //初始化 农历来计算相应的日期
            _24daysCalc.ChineseCalendar cc = new _24daysCalc.ChineseCalendar(dt);

            disc.Add("上一个节气", cc.ChineseTwentyFourPrevDay);
            disc.Add("下一个节气", cc.ChineseTwentyFourNextDay);
            disc.Add("阳历" ,cc.DateString);
            disc.Add("属相", cc.AnimalString);
            disc.Add("农历", cc.ChineseDateString);
            disc.Add("干支", cc.GanZhiDateString);
            disc.Add("干支历时辰", cc.ChineseHour);
            disc.Add("旬首", TianGanDiZhi.calcXunShou(dt));
            disc.Add("旬空", TianGanDiZhi.calcXunKong(dt)[0]+"  "+ TianGanDiZhi.calcXunKong(dt)[1]+"  "+ TianGanDiZhi.calcXunKong(dt)[2]+"  "+ TianGanDiZhi.calcXunKong(dt)[3]);


            return disc;

        }
    }
}
