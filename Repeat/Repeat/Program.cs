

// boxing-unboxing

//int num = 5;
//object t = num;
//num = 100;
//Console.WriteLine(num);
//int j = (int)t;


//upcasting-downcasting


using Repeat;
using System.Net.WebSockets;

//Animal animal1 = new Animal(); 

//Fish fish1 = new Fish();

//Animal animal3 = fish1;

//Animal animal2 = new Fish();

//Fish fish3 = (Fish)animal2;

//Book book = new Book();




//object[] animals = { book , 1,"Salam", animal1, fish1, animal3, animal2, fish3};

//foreach (var item in animals)
//{

//    Animal animal= item as Animal;

//    if (animal != null)
//    {
//        animal.Name = "canavar";
//        Console.WriteLine(animal.Name);
//    }


//if(item is Animal a)
//{
//    //((Animal)item).Name = "Tulku";
//Console.WriteLine(((Animal)item).Name);

//    a.Name = "Tulku";
//    Console.WriteLine(a.Name);
//}

//}


//byte age = 50;
//int age2 = age;

//byte num1 = 200;

//byte num2 = (byte)num1;

//Console.WriteLine(num2);


//Test();

//static void Test(int? a = null)
//{

//        Test2((int)a);


//}



//static void Test2(int m)
//{

//}

//IntList intlist = new IntList();

//intlist.Add(5);
//intlist.Add(5);
//intlist.Add(5);
//intlist.Add(5);
//intlist.Add(15);
//intlist.Add(15);
//intlist.Add(15);
//intlist.Add(15);

//var resul = intlist.GetAll();

//foreach (var item in resul)
//{
//    Console.WriteLine(item );
//}

//StringList stringList = new StringList();

//stringList.Add("salam");
//stringList.Add("salamlar");

//var res = stringList.GetAll();

//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}

//DataList<int> datas = new DataList<int>();

//datas.Add(1);
//datas.Add(2);
//datas.Add(3);
//datas.Add(4);

//var resul = datas.GetAll();

//foreach (var item in resul)
//{
//    Console.WriteLine(item);
//}


//DataList<string> words = new DataList<string>();

//words.Add("salam");
//words.Add("salam2");
//words.Add("salam3");
//words.Add("salam4");

//var list = words.GetAll();

//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}



//DataList<bool> statuses = new DataList<bool>();

//statuses.Add(true);
//statuses.Add(false);


//var listBool = statuses.GetAll();

//foreach (var item in listBool)
//{
//    Console.WriteLine(item);
//}


DataList<Book2> books = new DataList<Book2>();

books.Add(new Book2 { Id = 1, Name = "Xosrov ve Shirin" });
books.Add(new Book2 { Id = 2, Name = "Isgendername" });

//var result = books.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item.Name);
//}

//Repository<string> data1 = new Repository<string>();

//Repository<Book2> data2 = new Repository<Book2>();

//Repository<bool> data3 = new Repository<bool>();

var result = books.GetById(1);

Console.WriteLine(result.Name);


