using Abstract__Class_Abstract_Method.Models;

Eagle eagle = new Eagle();
//eagle.Fly();
//eagle.Eat();
//eagle.See();

Shark shark = new Shark();  
//shark.See();
//shark.Eat();
//shark.Svim();

Animal animal = new Eagle();
//animal.See();
//animal.Eat();

//foreach (var item in animals)
//{
//    animal.Eat();
//    animal.See();
//}

Animal[] animals = {eagle,shark};

for (int i = 0; i <animals.Length; i++)
{
    animal.Eat();
    animal.See();
}