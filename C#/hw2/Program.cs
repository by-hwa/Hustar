// See https://aka.ms/new-console-template for more information

// 로또 번호 생성기
// 1~45사이의 수를 가져야 한다.
// 로또 번호의 개수는 6개여야 한다.
// 로또 번호 6개는 마지막에 한번에 출력 되어야 한다.
// 중복된 수가 나오면 안된다.

Random random = new Random();

// 로또 중복체크용 반복 100번
// for(int k = 0;k<100;k++){
//     int[] lotto = new int[6];

//     bool state;

//     Console.Write("로또번호 : ");
//     for(int i = 0;i<6;i++){
//         state = false;
//         lotto[i] = random.Next(1,45);
//         while(true){
//             for(int j = 0;j<i;j++){
//                 if(lotto[i]==lotto[j]){state = true;lotto[i]=random.Next(1,45);}
//             }
//             if (state==false){break;}
//             state = false;
//         }   
//     }
    
//     Array.Sort(lotto);
//     Console.WriteLine($"{String.Join(",", lotto)}");
// }

int[] lotto = new int[6];

bool state;

Console.Write("로또번호 : ");
for(int i = 0;i<6;i++){
    state = false;
    lotto[i] = random.Next(1,45);
    while(true){
        for(int j = 0;j<i;j++){
            if(lotto[i]==lotto[j]){state = true;lotto[i]=random.Next(1,45);}
        }
        if (state==false){break;}
        state = false;
    }
}
Array.Sort(lotto);
Console.WriteLine(String.Join(" ", lotto)); // join 사용가능


// 가위 바위 보 게임
// 사용자의 가위 바위 보 입력을 한다.
// 컴퓨터는 무작위로 발생시킨다.
// 승패를 콘솔창에 출력한다.

string buffer;
int user = 0;
int computer = random.Next(1,3);

Console.Write("가위 바위 보 중 하나를 입력하세요 : ");
buffer = Console.ReadLine();

if(buffer=="가위"){user = 1;}
else if(buffer=="바위"){user = 2;}
else if(buffer=="보"){user = 3;}
else{Console.WriteLine("잘못된 값이 입력되었습니다.");}

int winner = user - computer;

if(computer==1){Console.WriteLine("컴퓨터 : 가위");}
else if(computer==2){Console.WriteLine("컴퓨터 : 바위");}
else if(computer==3){Console.WriteLine("컴퓨터 : 보");}

if(winner == 1 || winner == -2){Console.WriteLine("사용자가 승리하였습니다.");}
else if(winner == -1 || winner == 2){Console.WriteLine("사용자가 패배하였습니다.");}
else if(winner == 0){Console.WriteLine("무승부!");}