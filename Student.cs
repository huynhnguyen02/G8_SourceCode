using System;

class Student
{
    private string id;
    private string name;
    private float grade;
    public string getID()
    {
        return this.id;
    }
    public string getName()
    {
        return this.name;
    }
    public float getGrade()
    {
        return this.grade;
    }
    public Student(string id, string name, float grade)
    {
        this.id = id;
        this.name = name;
        this.grade = grade;
    }
    public override string ToString()
    {
        return "Student(" + id + "," + name + "," + grade + ")";
    }
}

