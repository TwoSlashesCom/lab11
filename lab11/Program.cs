using lab11;
using static lab11.Person;
using System;

static void Swap<T>(T[] a, int i, int j)
{
    T z = a[i]; 
    a[i] = a[j]; 
    a[j] = z;
}

static T[] DelElem<T>(T[] a, int index)
{
    T[] b = new T[a.Length - 1];
    
    for (int i = 0; i < index; i++)
    {
        b[i] = a[i];
    }

    for (int i = index + 1; i < a.Length; i++)
    {
        b[i - 1] = a[i];
    }

    return b;
}

double[] DoubleArray = {2.3, 3.5, 5.0, 2.0, 1.0};
int[] IntArray = {1, 2, 3, 4, 5};
string[] StringArray = {"first", "second", "third", "four", "five"};

Swap<double>(DoubleArray, 0, 2);
Swap<int>(IntArray, 1, 2);
Swap<string>(StringArray, 1, 3);

Console.WriteLine(string.Join(" ", DoubleArray));
Console.WriteLine(string.Join(" ", IntArray));
Console.WriteLine(string.Join(" ", StringArray));

string[] NewStringArray =  DelElem(StringArray, 1);
Console.WriteLine(string.Join(" ", NewStringArray));


Person[] r =
{
    new Person() {Name = "Name1", Surname = "Surname1", Gender = 'M' },
    new Person() {Name = "Name2", Surname = "Surname2", Gender = 'F' },
    new Person() {Name = "Name3", Surname = "Surname3", Gender = 'F' }
};

Array.Sort(r);
Array.ForEach(r, Console.WriteLine);
Swap(r, 0, 1);
Array.ForEach(r, Console.WriteLine);

Person[] r1 = DelElem(r, 1);
Array.ForEach(r1, Console.WriteLine);

if (r[0].CompareTo(r[0]) > 0)
{
    Console.WriteLine($"{r[0].Name} > {r[1].Name}");
}

if (r[0].CompareTo(r[0]) < 0)
{
    Console.WriteLine($"{r[0].Name} < {r[1].Name}");
}

if (r[0].CompareTo(r[0]) == 0)
{
    Console.WriteLine($"{r[0].Name} = {r[1].Name}");
}

Array.Sort(r, new PersonAgeComparator());
Array.ForEach(r, Console.WriteLine);

Array.Sort(r, new PersonGenderComparator());
Array.ForEach(r, Console.WriteLine);

static Person GetMax(Person[] people, IComparer<Person> comparer)
{
    Array.Sort(people, comparer);
    return people[people.Length - 1];
}
Person oldestPerson = GetMax(r, new PersonAgeComparator());
Person lastMale = GetMax(r, new PersonGenderComparator());


MyPair<Person, Person> pair1 = new MyPair<Person, Person>(r[0], r[1]);
Console.WriteLine("Первый из пары: {0} {1}", pair1.first.Name, pair1.first.Surname);
Console.WriteLine("Второй из пары: {0} {1}", pair1.second.Name, pair1.second.Surname);


