using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public struct Vector3
    {
        public float x, y, z;

        // get the magnitude of the vector
        // Magnitude = Length
        public float Magnitude
        {
            get
            {
                // Sqrt = square root 
                // Pow = power of 

                // c = sqrt(x^2 + y^2 + z^2)
                return (float)Math.Abs(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)));
            }
        }

        // Property to get the normalized version of the vector.
        // Normalization makes the vector length 1 while retaining its direction
        public Vector3 Normalized
        {
            get
            {
                // If the magnitude is 0, return a zero vector so you dont divide by zero
                if (Magnitude == 0)
                    return new Vector3();
                return this / Magnitude;
            }
        }


        // initialize the vector with specified x, y, and z values
        public Vector3(float x = 0, float y = 0, float z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // normalize the vector in place and return the normalized vector
        public Vector3 Normalize()
        {
            this = Normalized;
            return this;
        }

        // override the ToString
        public override string ToString()
        {

            return "(" + x + ", " + y + ", " + z +")";
        }

        // calculate the dot product with another vector
        public float DotProduct(Vector3 other)
        {
            return (x * other.x) + (y * other.y) + (z * other.z);
        }

         // calculate the cross product with another vector
        
        public Vector3 CrossProduct(Vector3 other)
        {
            return new Vector3((y * other.z - z * other.y) , (z * other.x - x * other.z) , (x * other.y - y * other.x)); 
        }

        // Operator overload for equality comparison
        public static bool operator ==(Vector3 left, Vector3 right)
        {
            return (left.x == right.x) && (left.y == right.y) && (left.z == right.z);
        }

        // Operator overload for inequality comparison
        public static bool operator !=(Vector3 left, Vector3 right)
        {
            return !(left == right);
        }

        // Operator overload for addition
        public static Vector3 operator +(Vector3 left, Vector3 right)
        {
            return new Vector3(left.x + right.x, left.y + right.y, left.z + right.z);
        }

        // Operator overload for subtraction
        public static Vector3 operator -(Vector3 left, Vector3 right)
        {
            return new Vector3(left.x - right.x, left.y - right.y, left.z - right.z);
        }

        //Operator overload for multiplication by a vector
        public static Vector3 operator *(Vector3 left, float scalar )
        {
            return new Vector3(left.x * scalar, left.y * scalar, left.z * scalar);
        }

        //Operator overload for multiplication by a scalar * vector
        public static Vector3 operator *(float scalar, Vector3 left)
        {
            return new Vector3(scalar * left.x, scalar * left.y, scalar * left.z);
        }

        // Operator overload for division
        public static Vector3 operator /(Vector3 left, float scalar)
        {
            return new Vector3(left.x / scalar, left.y / scalar, left.z / scalar);
        }

        // implicit conversion form system.Numerics.Vector3 to Vector3

        public static implicit operator Vector3(System.Numerics.Vector3 vector)
        {
            return new Vector3(vector.X, vector.Y, vector.Z);
        }

        // implicit conversion from Vector3 to Sysrem.Numerics.Vector3
        public static implicit operator System.Numerics.Vector3(Vector3 vector)
        {
            return new System.Numerics.Vector3(vector.x, vector.y, vector.z);
        }

    }


}
