# <ins> MathLibrary 

Welcome to the documentation for my MathLibrary

## Table of Contents

- [Vector2](#vector2)
- [Vector3](#vector3)
- [Vector4](#vector4)
- [Matrix3](#matrix3)
- [Matrix4](#matric4)



#   Vector2 

## Description

Representation of 2D vectors and points 

## Properties

| Component| Description|
|:------------:|:-----------------------------------------:|
| X            | Represents the X component of the vector|
| Y            | Represents the Y component of the vector|
| Magnitude    | Property to get the magnitude of the vector|
| Normalized   | Property to get the normalized version of the vector|

##  Methods
|Methods|Decsription|
|:----------:|:-----------:|
|ToString    | Returns the vector as a string|
|DotProduct  | Takes two vectors and returns a scalar|
|Distance    | Subtracts the two vectors and returns the distance betweens them|
|Angle       | Calculates the angle between the current two vectors and Returns the unsigned angle|
           
## Operator Overloads
|Operator|Description|
|:------:|:---------:|
|==      |Overload compares vectors if they are equal return true|
|!=      |Overload compares vectors if they are not equal return false|
|+       |Overload for adding vectors|
|-       |Overload for subtracting vectors|
|Vector*Scalar|Overload for multiplying vector by a scalar|
|Scalar*Vector |Overload for multiplying scalar by a vector|
|/ |Overload for dividing vector by a scalar|
|(System.Numerics.Vector2 Vector2)|Converts a System.Numerics.Vector2 to a custom Vector2 by copying the X and Y|
|(Vector2 System.Numerics.Vector2)|Converts a custom Vector 2  to a System.Numerics.Vector2 by copying the X and Y|

#  Vector3

## Description

Representation of 3D vectors and points 

## Properties

| Component| Description|
|:------------:|:-----------------------------------------:|
| X            | Represents the X component of the vector|
| Y            | Represents the Y component of the vector|
| Z            | Represents the Z component of the vector|
| Magnitude    | Property to get the magnitude of the vector|
| Normalized   | Property to get the normalized version of the vector|

##  Methods
|Methods|Decsription|
|:----------:|:-----------:|
|To String   | Returns the vector as a string|
|Dot Product | Takes two vectors and returns a scalar|
|Cross Product| Takes two vectors and returns a new vector that is perpendicular to the original vectors|
|Distance    | Subtracts the two vectors and returns the distance betweens them|
|Angle       | Calculates the angle between the current two vectors and Returns the unsigned angle|

## Operator Overloads
|Operator|Description|
|:------:|:---------:|
|==      |Overload compares vectors if they are equal return true|
|!=      |Overload compares vectors if they are not equal return false|
|+       |Overload for adding vectors|
|-       |Overload for subtracting vectors|
|Vector*Scalar|Overload for multiplying vector by a scalar|
|Scalar*Vector |Overload for multiplying scalar by a vector|
|/ |Overload for dividing vector by a scalar|
|(System.Numerics.Vector3 Vector3)|Converts a System.Numerics.Vector3 to a custom Vector3 by copying the X, Y, and Z|
|(Vector3 System.Numerics.Vector3)|Converts a custom Vector 3  to a System.Numerics.Vector3 by copying the X, Y, and Z|

# Vector4
## Description

Representation of 3D vectors and points 

## Properties

| Component| Description|
|:------------:|:-----------------------------------------:|
| W            | Represents the W component of the vector|
| X            | Represents the X component of the vector|
| Y            | Represents the Y component of the vector|
| Z            | Represents the Z component of the vector|
| Magnitude    | Property to get the magnitude of the vector|
| Normalized   | Property to get the normalized version of the vector|

##  Methods
|Methods|Decsription|
|:----------:|:-----------:|
|To String   | Returns the vector as a string|
|Dot Product | Takes two vectors and returns a scalar|
|Cross Product| Takes two vectors and returns a new vector that is perpendicular to the original vectors|
|Distance    | Subtracts the two vectors and returns the distance betweens them|
|Angle       | Calculates the angle between the current two vectors and Returns the unsigned angle|

## Operator Overloads
|Operator|Description|
|:------:|:---------:|
|==      |Overload compares vectors if they are equal return true|
|!=      |Overload compares vectors if they are not equal return false|
|+       |Overload for adding vectors|
|-       |Overload for subtracting vectors|
|Vector*Scalar|Overload for multiplying vector by a scalar|
|Scalar*Vector |Overload for multiplying scalar by a vector|
|/ |Overload for dividing vector by a scalar|
|(System.Numerics.Vector3 Vector3)|Converts a System.Numerics.Vector3 to a custom Vector3 by copying the X, Y, and Z|
|(Vector3 System.Numerics.Vector3)|Converts a custom Vector 3  to a System.Numerics.Vector3 by copying the X, Y, and Z|


# Matrix3
## Description
Represents a 3x3 rectangular array or table of numbers

