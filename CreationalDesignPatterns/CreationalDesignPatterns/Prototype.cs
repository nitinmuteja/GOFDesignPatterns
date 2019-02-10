using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns
{
    public abstract class Prototype
    {
        public virtual string Prop1 { get; set; }

        public virtual int Prop2 { get; set; }
        public abstract Prototype Clone();
    }

    public class ConcretePrototypeA : Prototype
    {
        public override Prototype Clone()
        {
            // Shallow Copy: only top-level objects are duplicated
            return (Prototype)MemberwiseClone();

            // Deep Copy: all objects are duplicated
        }
    }

    public class ConcretePrototypeB : Prototype
    {
        public override Prototype Clone()
        {
            // Shallow Copy: only top-level objects are duplicated
            return (Prototype)MemberwiseClone();

            // Deep Copy: all objects are duplicated
        }
    }


    public class Program
    {

        public static void UsingProtoType()
        {
          Prototype typeA=new ConcretePrototypeA();
            //suppose the properties are populated through DB calls
            typeA.Prop1 = "A";
            typeA.Prop2 = 1;
            Prototype typeACopy = typeA.Clone();

            Prototype typeB = new ConcretePrototypeB();
            //suppose the properties are populated through DB calls
            typeA.Prop1 = "B";
            typeA.Prop2 = 2;
            Prototype typeBCopy = typeB.Clone();

            Prototype typeAOrig = new ConcretePrototypeA();
            //suppose the properties are populated through DB calls
            typeAOrig.Prop1 = "AB";
            typeAOrig.Prop2 = 3;
            Prototype typeBNewCopy = typeAOrig.Clone();


        }

    }
}
