using System;

namespace curso_csharp.Entities;

public class LogStudents
{
    public int StudentNumber { get; set; }

    public override int GetHashCode()
    {
        return StudentNumber.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        if (!(obj is LogStudents)) { return false; }

        LogStudents other = obj as LogStudents;

        return StudentNumber.Equals(other.StudentNumber);
    }

    public override string ToString()
    {
        return $"Deu bom! debug: {StudentNumber}";
    }
}
