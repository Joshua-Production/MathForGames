using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public struct Vector4
    {
        public float x, y, z, w;

        // get the magnitude of the vector
        // Magnitude = Length
        public float Magnitude
        {
            get
            {
                // Sqrt = square root 
                // Pow = power of 

                // c = sqrt(x^2 + y^2 + z^2 + w^2)
                return (float)Math.Abs(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2) + Math.Pow(w, 2)));
            }
        }

        // Property to get the normalized version of the vector.
        // Normalization makes the vector length 1 while retaining its direction
        public Vector4 Normalized
        {
            get
            {
                // If the magnitude is 0, return a zero vector so you dont divide by zero
                if (Magnitude == 0)
                    return new Vector4();
                return this / Magnitude;
            }
        }


        // initialize the vector with specified x, y, z, and w values
        public Vector4(float x = 0, float y = 0, float z = 0, float w = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        // normalize the vector in place and return the normalized vector
        public Vector4 Normalize()
        {
            this = this.Normalized;
            return this;
        }

        // override the ToString
        public override string ToString()
        {

            return "(" + x + ", " + y + ", " + z + ", " + w +")";
        }

        // calculate the dot product with another vector
        public float DotProduct(Vector4 other)
        {
            return (x * other.x) + (y * other.y) + (z * other.z) + (w * other.w);
        }
        // calculate the cross product with another vector
        public Vector4 CrossProduct(Vector4 other)
        {
            return new Vector4((y * other.z - z * other.y), (z * other.x - x * other.z), (x * other.y - y * other.x),(w = 0));
        }

        // Operator overload for equality comparison
        public static bool operator ==(Vector4 left, Vector4 right)
        {
            return (left.x == right.x) && (left.y == right.y) && (left.z == right.z) && (left.w == right.w);
        }

        // Operator overload for inequality comparison
        public static bool operator !=(Vector4 left, Vector4 right)
        {
            return !(left == right);
        }

        // Operator overload for addition
        public static Vector4 operator +(Vector4 left, Vector4 right)
        {
            return new Vector4(left.x + right.x, left.y + right.y, left.z + right.z, left.w + right.w);
        }

        // Operator overload for subtraction
        public static Vector4 operator -(Vector4 left, Vector4 right)
        {
            return new Vector4(left.x - right.x, left.y - right.y, left.z - right.z, left.w - right.w);
        }

        //Operator overload for multiplication by a vector
        public static Vector4 operator *(Vector4 left, float scalar)
        {
            return new Vector4(left.x * scalar, left.y * scalar, left.z * scalar, left.w * scalar);
        }

        //Operator overload for multiplication by a scalar * vector
        public static Vector4 operator *(float scalar, Vector4 left)
        {
            return new Vector4(scalar * left.x, scalar * left.y, scalar * left.z, scalar * left.w);
        }

        // Operator overload for division
        public static Vector4 operator /(Vector4 left, float scalar)
        {
            return new Vector4(left.x / scalar, left.y / scalar, left.z / scalar, left.w /scalar);
        }

        // implicit conversion form system.Numerics.Vector4 to Vector4

        public static implicit operator Vector4(System.Numerics.Vector4 vector)
        {
            return new Vector4(vector.X, vector.Y, vector.Z, vector.W);
        }

        // implicit conversion from Vector4 to Sysrem.Numerics.Vector4
        public static implicit operator System.Numerics.Vector4(Vector4 vector)
        {
            return new System.Numerics.Vector4(vector.x, vector.y, vector.z, vector.w);
        }

    }


}
