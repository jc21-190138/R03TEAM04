using System;
using System.Collections;
using System.Text;
using SQLite;

namespace NavPageSample
{
    public class SQLite
    {

    }

    /*表(スキーマ)の定義*/
    public class User
        //ユーザーテーブル
    {
        //User_id、PK
        [PrimaryKey,AutoIncrement,Column("User_id")]
        //[unique]
        public int User_id { get;  set; }

        //生年月日
        [NotNull]
        public string Date_of_birth { get; set; }
        //性別
        [NotNull]
        public string  Sex { get; set; }
        //血液型
        [NotNull]
        public string BoodType { get; set; }
        //身長
        [NotNull]
        public int Height { get; set; }
        //体重
        [NotNull]
        public  int Weight { get; set; }
        //タバコ
        [NotNull]
        public string Tabako { get; set; }
        //お酒
        [NotNull]
        public string Drinking { get; set; }
        //薬の服用歴
        [NotNull]
        public string Taking_history { get; set; }

        //平日
        //朝食、出勤、昼食
        [NotNull]
        public string Day_breakfast { get; set; }
        [NotNull]
        public string Clockin_time { get; set; }
        [NotNull]
        public string Day_lunch { get; set; }

        //休日
        //朝食、昼食
        [NotNull]
        public string End_breakfast { get; set; }
        [NotNull]
        public string End_lunch { get; set; }


    }

    //薬テーブル
    public class Medicine
    {
        //薬のID
        [PrimaryKey,AutoIncrement,Column("Medicine_id")]
        public int Medicine_id { get; set; }
        //薬の名前
        [NotNull]
        public string Medicine_name { get; set; }
        //薬のURL
        public string Url { get; set; }

        public string timing { get; set; }
    }

    //アレルギーテーブル
    public class Allergie
    {
        //
        [PrimaryKey, AutoIncrement, Column("User_id")]
        public int User_id { get; set; }
        //アレルギーのID
        [NotNull]
        public string Allergie_id{ get; set; }
    }

    //薬の服用テーブル
    public class TakeMedicine
    {
        //
        [PrimaryKey, AutoIncrement, Column("User_id")]
        public int User_id { get; set; }
        //
        [PrimaryKey, AutoIncrement, Column("Medicine_id")]
        public int Medicine_id { get; set; }
        //
        [NotNull]
        public string Taking_history { get; set; }

        //一度に飲む薬の量
        [NotNull]
        public int Quantity { get; set; }
        //副作用
        public string Side_effect { get; set; }
    }

    //飲む時間テーブル
    public class TakeTime
    {
        //
        [PrimaryKey,AutoIncrement,Column("User_id")]
        public int User_id { get; set; }
        //
        [PrimaryKey, AutoIncrement, Column("Medicine_id")]
        public int Medicine_id { get; set; }
        //薬を飲む時間
        [NotNull]
        public string Medicine_time { get; set; }
    }

}
