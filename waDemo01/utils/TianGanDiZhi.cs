using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waDemo01.utils
{

    class TianGanDiZhi
    {

       

        public static String calcXunShou(DateTime dt) {
            //初始化 农历来计算相应的日期
            _24daysCalc.ChineseCalendar cc = new _24daysCalc.ChineseCalendar(dt);
            //计算出来的干支历的时辰
            String time=cc.ChineseHour;
            //计算对应 时辰的旬首
            char tian = time.ToCharArray()[0];
            char di = time.ToCharArray()[1];
            //地支-天干=六甲旬数
            int t=Convert.ToInt32(Enum.Parse(typeof(TianGan), ""+ tian));
            int d=Convert.ToInt32(Enum.Parse(typeof(DiZhi), ""+di));
            int res = -1;
            if (d < t)
            {
                res = (d + 12) - t;
            }
            else {
                res = d - t;
            }
            String resStr = "";
            //判断余数 0子 2寅 4辰 6午 8申 10戌
            switch (res) {
                case 0:
                    resStr= "甲子旬";
                    break;
                case 2:
                    resStr= "甲寅旬";
                    break;
                case 4:
                    resStr= "甲辰旬";
                    break;
                case 6:
                    resStr= "甲午旬";
                    break;
                case 8:
                    resStr= "甲申旬";
                    break;
                case 10:
                    resStr= "甲戌旬";
                    break;
                default:
                    throw new Exception("旬首计算错误！");
                    break;


            }
            
            return resStr;

        }


        public static ArrayList calcXunKong(DateTime dt)
        {
            //初始化 农历来计算相应的日期
            _24daysCalc.ChineseCalendar cc = new _24daysCalc.ChineseCalendar(dt);

            ArrayList list = new ArrayList();
            String riqi1 = cc.GanZhiDateString;
            String riqi2 = cc.ChineseHour;
            String []year=riqi1.Split('年');
            String[] month = year[1].Split('月');
            String[] day = month[1].Split('日');
            //下面的是每一个 用神的干支算法
            //list.Add(year[0]);
            //list.Add(month[0]);
            //list.Add(day[0]);
            //list.Add(riqi2);

            list.Add(getXKongAlg(year[0]));
            list.Add(getXKongAlg(month[0]));
            list.Add(getXKongAlg(day[0]));
            list.Add(getXKongAlg(riqi2));

            return list;
        }

        /// <summary>
        /// 根据 用神是年干 月干 还是日干 跟时干 来进行旬空的判断
        /// </summary>
        /// <param name="ganzhi"></param>
        /// <returns></returns>
        public static String getXKongAlg(String ganzhi) {

            String resStr = "";

            char tian = ganzhi.ToCharArray()[0];
            char di = ganzhi.ToCharArray()[1];
            //地支-天干=六甲旬数
            int t = Convert.ToInt32(Enum.Parse(typeof(TianGan), "" + tian));
            int d = Convert.ToInt32(Enum.Parse(typeof(DiZhi), "" + di));
            int res = -1;
            if (d < t)
            {
                res = (d + 12) - t;
            }
            else
            {
                res = d - t;
            }

            //判断余数 来断定 旬空的位置
            switch (res)
            {
                case 0:
                    resStr = "戌亥";
                    break;
                case 10:
                    resStr = "申酉";
                    break;
                case 8:
                    resStr = "午未";
                    break;
                case 6:
                    resStr = "辰巳";
                    break;
                case 4:
                    resStr = "寅卯";
                    break;
                case 2:
                    resStr = "子丑";
                    break;
                default:
                    throw new Exception("旬空计算错误！");
                    break;


            }


            return resStr;

        }


    }



    /// <summary>
    /// 方位
    /// </summary>
    public enum Postion
    {
        /// <summary>
        /// 东
        /// </summary>
        [Description("东")]
        East,
        /// <summary>
        /// 东南
        /// </summary>
        [Description("东南")]
        SouthEast,
        /// <summary>
        /// 南
        /// </summary>
        [Description("南")]
        South,
        /// <summary>
        /// 西南
        /// </summary>
        [Description("西南")]
        SouthWest,
        /// <summary>
        /// 西
        /// </summary>
        [Description("西")]
        West,
        /// <summary>
        /// 西北
        /// </summary>
        [Description("西北")]
        NorthWest,
        /// <summary>
        /// 北
        /// </summary>
        [Description("北")]
        North,
        /// <summary>
        /// 东北
        /// </summary>
        [Description("东北")]
        NorthEast,

        /// <summary>
        /// 中央
        /// </summary>
        [Description("中央")]
        Middle
    }
}
