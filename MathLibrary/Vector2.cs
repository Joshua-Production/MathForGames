using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MathLibrary
{
    public struct Vector2
    {
        public float x, y;

        // Property to get the magnitude of the vector
        public float Magnitude // Magnitude = Lenght
        {
            get
            {
                // Sqrt = square root 
                // Pow = power of 
               
                // c = sqrt(x^2 + y^2)
                return (float)Math.Abs(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));
            }
        }

        // Property to get the normalized version of the vector
        // Normalization makes the vector length 1 while keeping its direction
        public Vector2 Normalized
        {
            get
            {
                // If the magnitude is 0, return a zero vector so you dont divide by zero
                if (Magnitude == 0)
                    return new Vector2();

                return this / Magnitude;
            }
        }


        //  initialize the vector with a set x and y values
        public Vector2(float x = 0, float y = 0)
        {
            this.x = x;
            this.y = y;
        }

        // normalize the vector in place and return it normalized vector
        public Vector2 Normalize()
        {
            this = this.Normalized;
            return this;
        }
        
        // Override To string
        public override string ToString()
        {
            
            return "(" + x + ", " + y + ")";
        }

        // calculate the dot product with another vector
        public float DotProduct(Vector2 other)
        {
            // Formula A·B = Ax * Bx + Ay * By
            return (x * other.x) + (y * other.y);
        }

        // calculate the distance to another vector
        public float Distance(Vector2 other)
        {
            return (other - this).Magnitude;
        }

        // calculate the angle in radians between this vector and another vector
        public float Angle(Vector2 other)
        {
            // use the dot product to find the angle
            return (float)Math.Acos(other.DotProduct(this));
        }

        // overload for equality comparison
        public static bool operator ==(Vector2 left , Vector2 right)
        {
            return (left.x == right.x) && (left.y == right.y);
        }

        // overload for inequality comparison
        public static bool operator !=(Vector2 left, Vector2 right)
        {
            return !(left == right);
        }

        // Operator overload for addition
        public static Vector2 operator +(Vector2 left, Vector2 right)
        {
            return new Vector2(left.x + right.x, left.y + right.y);
        }

        // Operator overload for subtraction
        public static Vector2 operator -(Vector2 left, Vector2 right)
        {
            return new Vector2(left.x - right.x, left.y - right.y);
        }

        //Operator overload for multiplication by a vector * scalar
        public static Vector2 operator *(Vector2 left, float scalar)
        {
            return new Vector2(left.x * scalar, left.y * scalar);
        }

        //Operator overload for multiplication by a scalar * vector
        public static Vector2 operator *(float scalar ,Vector2 left)
        {
            return new Vector2(scalar * left.x , scalar * left.y);
        }

        // Operator overload for division
        public static Vector2 operator /(Vector2 left, float scalar)
        {
            return new Vector2(left.x / scalar, left.y / scalar);
        }

        // implicit conversion form system.Numerics.Vector2 to Vector2

         public static implicit operator Vector2(System.Numerics.Vector2 vector)
        {
            return new Vector2(vector.X, vector.Y);
        }

        // implicit conversion from Vector2 to Sysrem.Numerics.Vector2
        public static implicit operator System.Numerics.Vector2(Vector2 vector)
        {
            return new System.Numerics.Vector2(vector.x, vector.y);
        }

    }

    

}
