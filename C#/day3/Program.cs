// See https://aka.ms/new-console-template for more information

Dog dog = new Dog();

// dog.Bark();
// // dog.Display();
// Console.WriteLine("Eyes = {0}", dog.GetEyes());

// Dog dog2 = new Dog(2,1,1,2);
// // dog2.Display();
// Console.WriteLine("Eyes = {0}", dog2.GetEyes());
// dog2.SetEyes(5);
// Console.WriteLine("Eyes = {0}", dog2.GetEyes());

dog.DogInfo("푸들",1);
dog.DogInfo("갱얼쥐");

Person bh = new Person();
bh.Show_Inf();

Buldok bd = new Buldok();
bd.BuldokInformation();
bd.BuldokBark();

public class Dog{
    protected int eyes, nose, mouse, ears;
    virtual public void Bark(){ // virtual 을 사용하여 자식 클래스에서 오버라이딩 가능
        Console.WriteLine("Wal Wal");
    }

    public void DogInfo(string name){
        Console.WriteLine("name = {0}", name);
    }

    public void DogInfo(string name, int sex){
        Console.WriteLine("name : {0} sex : {1}",name, sex);
    }

    // 생성자 / 초기화 하는 역할을 많이 함.
    public Dog(){
        eyes = 0;
        nose = 0;
        mouse = 0;
        ears = 0;
    }
    // 생성자는 여러개 생성가능 단, 동일한 생성자는 매개변수가 달라야함.
    public Dog(int eyes, int nose, int mouse, int ears){
        this.eyes = eyes; // this. 를 이용해서 앞의 변수는 class 내에 선언된 변수라는 것을 알려줌
        this.nose = nose;
        this.mouse = mouse;
        this.ears = ears;
    }

    // 매서드

    public void Display(){
        Console.WriteLine("eyes = {0}", eyes);
        Console.WriteLine("nose = {0}", nose);
        Console.WriteLine("mouse = {0}", mouse);
        Console.WriteLine("ears = {0}", ears);
    }

    public int GetEyes(){return this.eyes;}
    public int GetNose(){return this.nose;}
    public int GetMouse(){return this.mouse;}
    public int GetEars(){return this.ears;}

    public void SetEyes(int eyes){this.eyes = eyes;}
    public void SetNose(int nose){this.nose = nose;}
    public void SetMouse(int mouse){this.mouse = mouse;}
    public void SetEars(int ears){this.ears = ears;}

}


class Person{
    private string? name, sex;
    private int age, weight, height;

    public Person(){
        name = "이름";
        sex = "미지정";
        age = 0;
        weight = 60;
        height = 175;
    }

    public Person(string name, string sex, int age, int weight, int height){
        this.name = name;
        this.sex = sex;
        this.age = age;
        this.weight = weight;
        this.height = height;
    }

    public void Show_Inf(){Console.WriteLine("이름 : {0} 성별 : {1} 나이 : {2} 키 : {3} 무게 : {4}",this.name,this.sex,this.age,this.height,this.weight);}

    public void Set_Name(string name){this.name = name;}
    public void Set_Sex(string sex){this.sex = sex;}
    public void Set_Age(int age){this.age = age;}
    public void Set_Weight(int weight){this.weight = weight;}
    public void Set_Height(int height){this.height = height;}
}

public class Buldok:Dog{
    private string kind;

    override public void Bark(){ // override  를 붙여 오버라이딩함을 표시하여줌
        Console.WriteLine("Wal Wal");
    }
    public Buldok(){
        // base.eyes = 0; // 상속받은 변수 임을 알려주는 base. 을 알려줌.
        // base.nose = 0; // 인자 값이 없는 생성자, 함수를 생성할땐 생략가능
        // base.mouse = 0;
        // base.ears = 0;
        this.kind = "불독";
    }

    public void BuldokInformation(){
        Console.WriteLine("Buldok eyes = {0}", base.eyes);
        Console.WriteLine("Buldok nose = {0}", base.nose);
        Console.WriteLine("Buldok mouse = {0}", base.mouse);
        Console.WriteLine("Buldok ears = {0}", base.ears);
        Console.WriteLine("Buldok kind = {0}", this.kind);
    }

    public void BuldokBark(){
        Console.WriteLine("불독불독!!");
    }

    public string GetKind(){return this.kind;}
    public void SetKind(string kind){this.kind = kind;}
}