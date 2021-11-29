using System;

namespace ExtendMath
{
    /// <summary>
    /// Main class for math functions and classes
    /// </summary>
    public static class EMath
    {
        /*        CLASS          */
        /// <summary>
        /// Vector with 2 elements
        /// </summary>
        public class Vector2
        {
            /// <summary>
            /// Element value
            /// </summary>
            public float X, Y;
            /// <summary>
            /// Empty constructor
            /// </summary>
            public Vector2() { }
            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            public Vector2(float x, float y)
            {
                X = x;
                Y = y;
            }
            /// <summary>
            /// Add vector b to a and return the sum
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static Vector2 operator +(Vector2 a, Vector2 b) => new Vector2(a.X + b.X, a.Y + b.Y);
            /// <summary>
            /// Add float value to vector and return the sum
            /// </summary>
            /// <param name="a"></param>
            /// <param name="f"></param>
            /// <returns></returns>
            public static Vector2 operator +(Vector2 a, float f) => new Vector2(a.X + f, a.Y + f);
            /// <summary>
            /// Sub vector b to a and return the sum
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static Vector2 operator -(Vector2 a, Vector2 b) => new Vector2(a.X - b.X, a.Y - b.Y);
            /// <summary>
            /// Sub float value to vector and return the sum
            /// </summary>
            /// <param name="a"></param>
            /// <param name="f"></param>
            /// <returns></returns>
            public static Vector2 operator -(Vector2 a, float f) => new Vector2(a.X - f, a.Y - f);
            /// <summary>
            /// Multiply vector b to a and return the sum
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static Vector2 operator *(Vector2 a, Vector2 b) => new Vector2(a.X * b.X, a.Y * b.Y);
            /// <summary>
            /// Multiply float value to vector and return the sum
            /// </summary>
            /// <param name="a"></param>
            /// <param name="f"></param>
            /// <returns></returns>
            public static Vector2 operator *(Vector2 a, float f) => new Vector2(a.X * f, a.Y * f);
            /// <summary>
            /// Divide vector b to a and return the sum
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static Vector2 operator /(Vector2 a, Vector2 b) => new Vector2(a.X / b.X, a.Y / b.Y);
            /// <summary>
            /// Multiply float value to vector and return the sum
            /// </summary>
            /// <param name="a"></param>
            /// <param name="f"></param>
            /// <returns></returns>
            public static Vector2 operator /(Vector2 a, float f) => new Vector2(a.X / f, a.Y / f);

        }
        /// <summary>
        /// Vector with 3 elements
        /// </summary>
        public class Vector3:Vector2
        {
            /// <summary>
            /// Element value
            /// </summary>
            public float Z;

            /// <summary>
            /// Empty constructor
            /// </summary>
            public Vector3()
            {
                X = 0;
                Y = 0;
                Z = 0;
            }

            /// <summary>
            /// Return new rotated vector by the X axis
            /// </summary>
            /// <param name="angle"></param>
            /// <returns></returns>
            public Vector3 RotatedX(float angle) => new Vector3
            (
                X,
                Y * (float)Math.Cos(angle) + Z * (float)-Math.Sin(angle),
                Y * (float)Math.Sin(angle) + Z * (float)Math.Cos(angle)
            );

            /// <summary>
            /// Return new rotated vector by the Y axis
            /// </summary>
            /// <param name="angle"></param>
            /// <returns></returns>
            public Vector3 RotatedY(float angle) => new Vector3
            (
                X * (float)Math.Cos(angle) + Z * (float)Math.Sin(angle),
                Y,
                X * (float)-Math.Sin(angle) + Z * (float)Math.Cos(angle)
            );
            /// <summary>
            /// Return new rotated vector by the Z axis
            /// </summary>
            /// <param name="angle"></param>
            /// <returns></returns>
            public Vector3 RotatedZ(float angle) => new Vector3
            (
                X * (float)Math.Cos(angle) + Y * (float)-Math.Sin(angle),
                X * (float)Math.Sin(angle) + Y * (float)Math.Cos(angle),
                Z
            );
            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <param name="z"></param>
            public Vector3(float x, float y, float z)
            {
                this.X = x;
                this.Y = y;
                this.Z = z;
            }

            /// <summary>
            /// Add vector b to a and return the sum
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static Vector3 operator +(Vector3 a, Vector3 b) => new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
            /// <summary>
            /// Add float value to vector and return the sum
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static Vector3 operator +(Vector3 a, float b) => new Vector3(a.X + b, a.Y + b, a.Z + b);
            /// <summary>
            /// Decrease vector b from a and return sum
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static Vector3 operator -(Vector3 a, Vector3 b) => new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
            /// <summary>
            /// Decrease float value from a and return sum
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static Vector3 operator -(Vector3 a, float b) => new Vector3(a.X - b, a.Y - b, a.Z - b);
            /// <summary>
            /// Multiply vector a and b and return sum
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static Vector3 operator *(Vector3 a, Vector3 b) => new Vector3(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
            /// <summary>
            /// Multiply vector a with float value and return sum
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static Vector3 operator *(Vector3 a, float b) => new Vector3(a.X * b, a.Y * b, a.Z * b);
            /// <summary>
            /// Multiply vector with matrix and return sum
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static Vector3 operator *(Vector3 a, Matrix3x3 b) => new Vector3(a.X * b.M11 + a.Y * b.M12 + a.Z * b.M13, a.X * b.M21 + a.Y * b.M22 + a.Z * b.M23, a.X * b.M31 + a.Y * b.M32 + a.Z * b.M33);
            /// <summary>
            /// Divide vector a with b and return sum
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static Vector3 operator /(Vector3 a, Vector3 b) => new Vector3(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
            /// <summary>
            /// Divide vector with float value and return sum
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static Vector3 operator /(Vector3 a, float b) => new Vector3(a.X / b, a.Y / b, a.Z / b);
            /// <summary>
            /// Implicit to float. Return the sum of all elements
            /// </summary>
            /// <param name="v"></param>
            public static implicit operator float(Vector3 v) =>v.X + v.Y + v.Z;
        }
        /// <summary>
        /// Matrix with 9 elements
        /// </summary>
        public class Matrix3x3
        {
            /// <summary>
            /// Element value
            /// </summary>
            public float M11, M12, M13, M21, M22, M23, M31, M32, M33;
            /// <summary>
            /// Return new vector contain m11,m12,m13 elements
            /// </summary>
            public Vector3 V1
            {
                get => new Vector3(M11, M12, M13);
            }
            /// <summary>
            /// Return new vector contain m21,m22,m23 elements
            /// </summary>
            public Vector3 V2
            {
                get => new Vector3(M21, M22, M23);
            }
            /// <summary>
            /// Return new vector contain m21,m22,m23 elements
            /// </summary>
            public Vector3 V3
            {
                get => new Vector3(M31, M32, M33);
            }
            /// <summary>
            /// Empty constructor
            /// </summary>
            public Matrix3x3() { }
            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="m11"></param>
            /// <param name="m12"></param>
            /// <param name="m13"></param>
            /// <param name="m21"></param>
            /// <param name="m22"></param>
            /// <param name="m23"></param>
            /// <param name="m31"></param>
            /// <param name="m32"></param>
            /// <param name="m33"></param>
            public Matrix3x3(float m11, float m12, float m13, float m21, float m22, float m23, float m31, float m32, float m33)
            {
                M11 = m11;
                M12 = m12;
                M13 = m13;
                M21 = m21;
                M22 = m22;
                M23 = m23;
                M31 = m31;
                M32 = m32;
                M33 = m33;
            }
            /// <summary>
            /// Constructor from 3 vectors
            /// </summary>
            /// <param name="v1"></param>
            /// <param name="v2"></param>
            /// <param name="v3"></param>
            public Matrix3x3(Vector3 v1, Vector3 v2, Vector3 v3)
            {
                M11 = v1.X;
                M12 = v1.Y;
                M13 = v1.Z;
                M21 = v2.X;
                M22 = v2.Y;
                M23 = v2.Z;
                M31 = v3.X;
                M32 = v3.Y;
                M33 = v3.Z;
            }
            /// <summary>
            /// Multiply matrix a with b and return sum
            /// </summary>
            /// <param name="m1"></param>
            /// <param name="m2"></param>
            /// <returns></returns>
            public static Matrix3x3 operator *(Matrix3x3 m1, Matrix3x3 m2) => new Matrix3x3
            (
               m1.M11 * m2.M11 + m1.M12 * m2.M12 + m1.M13 * m2.M13,
               m1.M11 * m2.M21 + m1.M12 * m2.M22 + m1.M13 * m2.M23,
               m1.M11 * m2.M31 + m1.M12 * m2.M32 + m1.M13 * m2.M33,
               m1.M21 * m2.M11 + m1.M22 * m2.M12 + m1.M23 * m2.M13,
               m1.M21 * m2.M21 + m1.M22 * m2.M22 + m1.M23 * m2.M23,
               m1.M21 * m2.M31 + m1.M22 * m2.M32 + m1.M23 * m2.M33,
               m1.M31 * m2.M11 + m1.M32 * m2.M12 + m1.M33 * m2.M13,
               m1.M31 * m2.M21 + m1.M32 * m2.M22 + m1.M33 * m2.M23,
               m1.M31 * m2.M31 + m1.M32 * m2.M32 + m1.M33 * m2.M33
            );
            /// <summary>
            /// Multiply matrix on vector and return sum
            /// </summary>
            /// <param name="m1"></param>
            /// <param name="m2"></param>
            /// <returns></returns>
            public static Matrix3x3 operator *(Matrix3x3 m1, Vector3 m2) => new Matrix3x3
            (
                m1.M11 * m2.X,
                m1.M12 * m2.Y,
                m1.M13 * m2.Z,
                m1.M21 * m2.X,
                m1.M22 * m2.Y,
                m1.M23 * m2.Z,
                m1.M31 * m2.X,
                m1.M32 * m2.Y,
                m1.M33 * m2.Z
            );
            /// <summary>
            /// Add vector values to the matrix
            /// </summary>
            /// <param name="m"></param>
            /// <param name="v"></param>
            /// <returns></returns>
            public static Matrix3x3 operator +(Matrix3x3 m, Vector3 v)
            {
                m.M11 += v.X;
                m.M21 += v.X;
                m.M31 += v.X;
                m.M12 += v.Y;
                m.M22 += v.Y;
                m.M32 += v.Y;
                m.M13 += v.Z;
                m.M23 += v.Z;
                m.M33 += v.Z;
                return m;
            }
        }
        /// <summary>
        /// Triangle with vertices/normals and texture coordinates
        /// </summary>
        public class Triangle
        {
            /// <summary>
            /// Vertices
            /// </summary>
            public Matrix3x3 V;
            /// <summary>
            /// Normals
            /// </summary>
            public Matrix3x3 VN;
            /// <summary>
            /// Texture coordinate 1
            /// </summary>
            public Vector2 vt1;
            /// <summary>
            /// Texture coordinate 2
            /// </summary>
            public Vector2 vt2;
            /// <summary>
            /// Texture coordinate 3
            /// </summary>
            public Vector2 vt3;
            /// <summary>
            /// Empty constructor
            /// </summary>
            public Triangle()
            {
                V = new Matrix3x3();
                VN = new Matrix3x3();

                vt1 = new Vector2();
                vt2 = new Vector2();
                vt3 = new Vector2();
            }
            /// <summary>
            /// Construct only vertices
            /// <para>All others properties will be NULL</para>
            /// </summary>
            /// <param name="v1"></param>
            /// <param name="v2"></param>
            /// <param name="v3"></param>
            public Triangle(Vector3 v1, Vector3 v2, Vector3 v3)
            {
                V = new Matrix3x3(v1,v2,v3);
            }
            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="V"></param>
            /// <param name="VN"></param>
            /// <param name="vt1"></param>
            /// <param name="vt2"></param>
            /// <param name="vt3"></param>
            public Triangle(Matrix3x3 V, Matrix3x3 VN, Vector2 vt1, Vector2 vt2, Vector2 vt3)
            {
                this.V = V;
                this.VN = VN;

                this.vt1 = vt1;
                this.vt2 = vt2;
                this.vt3 = vt3;
            }
            /// <summary>
            /// Create copy from exist triangle
            /// </summary>
            /// <param name="copy"></param>
            public Triangle(Triangle copy)
            {
                V = new Matrix3x3(copy.V.M11, copy.V.M12, copy.V.M13, copy.V.M21, copy.V.M22, copy.V.M23, copy.V.M31, copy.V.M32, copy.V.M33);
                VN = new Matrix3x3(copy.VN.M11, copy.VN.M12, copy.VN.M13, copy.VN.M21, copy.VN.M22, copy.VN.M23, copy.VN.M31, copy.VN.M32, copy.VN.M33);

                vt1 = new Vector2(copy.vt1.X, copy.vt1.Y);
                vt2 = new Vector2(copy.vt2.X, copy.vt2.Y);
                vt3 = new Vector2(copy.vt3.X, copy.vt3.Y);
            }

        }

        /*        FUNCTIONS          */
        /// <summary>
        /// Clamp value to fixed range
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="val"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static float Clamp(float val, float min, float max)
        {
            if (val < min) return min;
            if (val > max) return max;
            return val;
        }
        /// <summary>
        /// Retrun dot product between vector a to b
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static float Dot(Vector3 v1, Vector3 v2)=> v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        /// <summary>
        /// Return vector lenght
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static float Lenght(Vector3 v) => (float)Math.Sqrt(Dot(v, v));
        /// <summary>
        /// Return linear interpolate between 2 floats
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="ratio"></param>
        /// <returns></returns>
        public static float Lerp(float v1, float v2, float ratio) => v1 + ratio * (v2 - v1);
        /// <summary>
        /// Return shortest distance between point to plane
        /// </summary>
        /// <param name="vec"></param>
        /// <param name="plane"></param>
        /// <param name="normal"></param>
        /// <returns></returns>
        public static float Distance(Vector3 vec, Vector3 plane, Vector3 normal)=> Dot(normal, vec) - Dot(normal, plane);
        /// <summary>
        /// Check if character is part of floating point
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool PartOfFloat(char c)=> (c >= '0' && c <= '9') || c == '-' || c == '.';
        /// <summary>
        /// Converts float to byte
        /// <para>Min:0.0 Max:1.0;</para>
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static byte ToByte(float val)
        {
            if (val > 1) return 255;
            if (val < 0) return 0;
            return (byte)(val * 255);
        }
        /// <summary>
        /// Return clipped triangles
        /// </summary>
        /// <param name="plane"></param>
        /// <param name="normal"></param>
        /// <param name="triangle"></param>
        /// <returns></returns>
        public static Triangle[] TriangleAgainstClip(Triangle triangle)
        {
            Vector3 plane = new Vector3();
            Vector3 normal = new Vector3(0,0,1);

            Vector3[] inP = new Vector3[3];
            int inLen = 0;
            Vector3[] outP = new Vector3[3];
            int outLen = 0;

            Vector3 v1 = new Vector3(triangle.V.M11, triangle.V.M12, triangle.V.M13);
            Vector3 v2 = new Vector3(triangle.V.M21, triangle.V.M22, triangle.V.M23);
            Vector3 v3 = new Vector3(triangle.V.M31, triangle.V.M32, triangle.V.M33);

            float dist1 = Distance(v1, plane, normal);
            float dist2 = Distance(v2, plane, normal);
            float dist3 = Distance(v3, plane, normal);

            if (dist1 >= 0) inP[inLen++] = v1;
            else outP[outLen++] = v1;
            if (dist2 >= 0) inP[inLen++] = v2;
            else outP[outLen++] = v2;
            if (dist3 >= 0) inP[inLen++] = v3;
            else outP[outLen++] = v3;

            if (inLen == 3) return new Triangle[1] { triangle };
            else if (inLen == 1 && outLen == 2) return new Triangle[1]
            {
                new Triangle(new Matrix3x3
                (
                    inP[0], IntersectPlane(plane, normal, inP[0], outP[0]),IntersectPlane(plane, normal, inP[0], outP[1])
                ),
                    triangle.VN, triangle.vt1, triangle.vt2, triangle.vt3)
            };
            else if (inLen == 2 && outLen == 1)
            {
                Triangle one = new Triangle(new Matrix3x3(inP[0], inP[1], IntersectPlane(plane, normal, inP[0], outP[0])), triangle.VN, triangle.vt1, triangle.vt2, triangle.vt3);
                return new Triangle[2]
                {
                    one,
                    new Triangle(new Matrix3x3(inP[1], new Vector3(one.V.M31,one.V.M32,one.V.M33),IntersectPlane(plane, normal, inP[1], outP[0])),triangle.VN, triangle.vt1, triangle.vt2, triangle.vt3)
                };
            }
            return new Triangle[0];
        }
        /// <summary>
        /// Return normalize vector
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static Vector3 Normalize(Vector3 v)
        {
            float l = Lenght(v);
            return new Vector3(v.X / l, v.Y / l, v.Z / l);
        }
        /// <summary>
        /// Cross product between vector a to b
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Vector3 Cros(Vector3 v1, Vector3 v2) => new Vector3
        (
            v1.Y * v2.Z - v1.Z * v2.Y,
            v1.Z * v2.X - v1.X * v2.Z,
            v1.X * v2.Y - v1.Y * v2.X
        );
        /// <summary>
        /// Return linear interpolate between two vectors
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="ratio"></param>
        /// <returns></returns>
        public static Vector3 Lerp(Vector3 v1, Vector3 v2, float ratio) =>new Vector3
        (
        v1.X + ratio * (v2.X - v1.X),
        v1.Y + ratio * (v2.Y - v1.Y),
        v1.Z + ratio * (v2.Z - v1.Z)
        );
        /// <summary>
        /// Make projection vector
        /// </summary>
        /// <param name="fov"></param>
        /// <param name="aspect"></param>
        /// <param name="far"></param>
        /// <param name="near"></param>
        /// <returns></returns>
        public static Vector3 ProjectionVector(float fov, float aspect, float far, float near)
        {
            float ffov = 1.0f / (float)Math.Tan(fov * 0.5f);
            return new Vector3(ffov * aspect, ffov, far / (far - near));
        }
        /// <summary>
        /// Return forward vector relative to yaw and pitch
        /// </summary>
        /// <param name="yaw"></param>
        /// <param name="pitch"></param>
        /// <returns></returns>
        public static Vector3 ForwardVector(float yaw, float pitch) => new Vector3
        (
             (float)Math.Sin(yaw) * 0.02f,
            (float)-Math.Sin(pitch) * 0.02f,
            (float)(Math.Cos(yaw) * Math.Cos(pitch) * 0.02f)
        );
        /// <summary>
        /// Return right vector relative to yaw and pitch
        /// </summary>
        /// <param name="yaw"></param>
        /// <param name="pitch"></param>
        /// <returns></returns>
        public static Vector3 RightVector(float yaw, float pitch) => new Vector3
        (
            (float)(Math.Cos(yaw) * Math.Cos(pitch)) * 0.02f,
            (float)-Math.Sin(pitch) * 0.02f,
            (float)-Math.Sin(yaw) * 0.02f
        );
        /// <summary>
        /// Return point where line intersect with plane
        /// </summary>
        /// <param name="plane"></param>
        /// <param name="normal"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static Vector3 IntersectPlane(Vector3 plane, Vector3 normal, Vector3 start, Vector3 end)
        {
            plane = Normalize(plane);
            float planeD = -Dot(plane, normal);
            float ad = Dot(start, normal);
            float ed = Dot(end, normal);
            float t = (-planeD - ad) / (ed - ad);
            Vector3 startToEnd = end - start;
            Vector3 intersect = startToEnd * t;
            return start + intersect;
        }
        /// <summary>
        /// Return normal surface of triangle normalized
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="v3"></param>
        /// <returns></returns>
        public static Vector3 NormalSurface(Vector3 v1, Vector3 v2, Vector3 v3)
        {
            var line1 = v2 - v1;
            var line2 = v3 - v1;
            var normal = Cros(line1, line2);
            return Normalize(normal);
        }
        /// <summary>
        /// Return normal surface of triangle normalized
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="v3"></param>
        /// <returns></returns>
        public static Vector3 NormalSurface(Matrix3x3 m)
        {
            var v1 = new Vector3(m.M11, m.M12, m.M13);
            var v2 = new Vector3(m.M21, m.M22, m.M23);
            var v3 = new Vector3(m.M31, m.M32, m.M33);
            var line1 = v2 - v1;
            var line2 = v3 - v1;
            var normal = Cros(line1, line2);
            return Normalize(normal);
        }
        /// <summary>
        /// Return rotation matrix rotated by X axis
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static Matrix3x3 RotationXMatrix(float angle) => new Matrix3x3
           (
               1, 0, 0,
               0, (float)Math.Cos(angle), (float)-Math.Sin(angle),
               0, (float)Math.Sin(angle), (float)Math.Cos(angle)
           );
        /// <summary>
        /// Return rotation matrix rotated by Y axis
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static Matrix3x3 RotationYMatrix(float angle) => new Matrix3x3
        (
            (float)Math.Cos(angle), (float)Math.Sin(angle), 0,
            0, 1, 0,
            (float)-Math.Sin(angle), 0, (float)Math.Cos(angle)
        );
        /// <summary>
        /// Return rotation matrix rotated by Z axis
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static Matrix3x3 RotationZMatrix(float angle) => new Matrix3x3
        (
            (float)Math.Cos(angle), (float)-Math.Sin(angle), 0,
            (float)Math.Sin(angle), (float)Math.Cos(angle), 0,
            0, 0, 1
        );
        /// <summary>
        /// Return optimize rotation matrix
        /// </summary>
        /// <param name="yaw"></param>
        /// <param name="pitch"></param>
        /// <param name="roll"></param>
        /// <returns></returns>
        public static Matrix3x3 RotationMatrix(float yaw, float pitch, float roll)
        {
            float ycos = (float)Math.Cos(yaw);
            float ysin = (float)Math.Sin(yaw);
            float pcos = (float)Math.Cos(pitch);
            float psin = (float)Math.Sin(pitch);
            float rcos = (float)Math.Cos(roll);
            float rsin = (float)Math.Sin(roll);
            float ycps = ycos * psin;
            float ysps = ysin * psin;
            return new Matrix3x3
            (
                ycos * pcos,
                ycps * rsin - ysin * rcos,
                ycps * rcos + ysin * rsin,
                ysin * pcos,
                ysps * rsin + ycos * rcos,
                ysps * rcos - ycos * rsin,
                -psin,
                pcos * rsin,
                pcos * rcos
            );
        }
        /// <summary>
        /// Return a projection matrix
        /// </summary>
        /// <param name="fov"></param>
        /// <param name="aspect"></param>
        /// <param name="near"></param>
        /// <param name="far"></param>
        /// <returns></returns>
        public static Matrix3x3 ProjectionMatrix(float fov, float aspect, float near, float far)
        {
            float ffov = 1.0f / (float)Math.Tan(fov * 0.5f);
            return new Matrix3x3
            (
                ffov * aspect, 0, 0,
                0, ffov, 0,
                0, 0, far / (far - near)
            );
        }
        /// <summary>
        /// Return a scale matrix
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public static Matrix3x3 ScaleMatrix(float x, float y, float z) => new Matrix3x3
        (
            x, 0, 0,
            0, y, 0,
            0, 0, z
        );
        /// <summary>
        /// Return point at matrix
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="target"></param>
        /// <param name="up"></param>
        /// <returns></returns>
        public static Matrix3x3 PointAt(Vector3 pos, Vector3 target, Vector3 up)
        {
            Vector3 forVec = Normalize(target - pos);
            Vector3 upVec = Normalize(up - forVec * Dot(up, forVec));
            Vector3 rigVec = Cros(upVec, forVec);
            return new Matrix3x3
            (
                rigVec.X, rigVec.Y, rigVec.Z,
                upVec.X, upVec.Y, upVec.Z,
                forVec.X, forVec.Y, forVec.Z
            );
        }
        /// <summary>
        /// Return inverse matrix
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        public static Matrix3x3 Transpose(Matrix3x3 mat) => new Matrix3x3
        (
            mat.M11, mat.M21, mat.M23,
            mat.M12, mat.M22, mat.M32,
            mat.M13, mat.M23, mat.M33
        );
        /// <summary>
        /// Return look at matrix
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="target"></param>
        /// <param name="up"></param>
        /// <returns></returns>
        public static Matrix3x3 LookAt(Vector3 pos, Vector3 target, Vector3 up)
        {
            Vector3 forVec = Normalize(target - pos);
            Vector3 upVec = Normalize(up - forVec * Dot(up, forVec));
            Vector3 rigVec = Cros(upVec, forVec);
            return new Matrix3x3
            (
                rigVec.X, upVec.X, forVec.X,
                rigVec.Y, upVec.Y, forVec.Y,
                rigVec.Z, upVec.Z, forVec.Z
            );
        }
    }
}
