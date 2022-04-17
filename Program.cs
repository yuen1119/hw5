// See https://aka.ms/new-console-template for more information
Console.WriteLine("基本資料填寫");
    Console.WriteLine("請輸入姓名");
    string ? name=Console.ReadLine();
    Console.WriteLine("請輸入性別1.男性2.女性");
    string ? sex=Console.ReadLine();
    if(sex=="1"){
        Console.WriteLine("1.男性");
    }
    else{
        Console.WriteLine("2.女性");
    }
    Console.WriteLine("請輸入出生年月日");
    string brith=Console.ReadLine();
    Console.WriteLine("請輸入學號");
    string ID=Console.ReadLine();
    end:
    Console.WriteLine("=========================");
    choose:
    Console.WriteLine("=========================");
    Console.WriteLine("姓名:"+name);
    Console.WriteLine("性別:"+sex);
    Console.WriteLine("生日:"+brith);
    Console.WriteLine("學號:"+ID);
    Console.WriteLine("以上是否正確?");
    Console.WriteLine("以上資料是否正確?\n正確請輸入1\n重新填寫請輸入2");
    string inum=Console.ReadLine();
    if(inum=="1"){
        Console.WriteLine("1.已完成資料建設");
    }
    else if(inum=="2"){
        Console.WriteLine("2.重新開始詢問資料填寫");
        Console.WriteLine("請選擇填寫部分\t1.姓名\t2.性別\t3.生日\t4.學號");
        string rewrite;
        rewrite=Console.ReadLine();
        
        switch(rewrite)
        {
            case"1":
            Console.WriteLine("請輸入姓名");
            name=Console.ReadLine();
            goto choose;
            break;

             case"2":
            Console.WriteLine("請輸入性別1.男性2.女性");
            sex=Console.ReadLine();
            goto choose;
            break;

             case"3":
            Console.WriteLine("請輸入出生年月日");
            brith=Console.ReadLine();
            goto choose;
            break;

             case"4":
            Console.WriteLine("請輸入學號");
            ID=Console.ReadLine();
            goto choose;
            break;

            default:
            Console.WriteLine("請輸入上述數字");
            break;
        
        }
    }
    else{
            Console.WriteLine("請輸入上述數字");
            goto choose;
    }

