# Computer Graphics
Implementing functions to draw:
- Lines (Using Bresenham algorithm)
- Circles (Using Bresenham algorithm)
- Bezier Curves using the following steps:
  1. Receiving 4 points.
  2. Create 2 seperate vectors: first vecotr is from the points X's and second vector is from the points Y's.
  3. Multiply the vectors separately in bezier matrix to calculate a,b,c,d equation constants.
  4. Calculate a new point on the curve using the following polynomials:
     ![Polynomials](https://user-images.githubusercontent.com/12692788/55683858-220ad580-594d-11e9-9050-6723b251511f.jpg)
    
    		t values is between 0 and 1 (Taking smaller steps equals smoother bezier curve)
    
   5. Draw a line between the previous point and the new point.
   6. Increment t by the step size.
   
          Repeate steps iv ~ vi until t >= 1
  
![SimplePaint](https://user-images.githubusercontent.com/12692788/55684043-613a2600-594f-11e9-9557-bb54ce911255.jpg)

   
    
