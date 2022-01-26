#ifndef MYHLSLINCLUDE_INCLUDED
#define MYHLSLINCLUDE_INCLUDED



void Custom_float(float In, out float Out)
{
if(In<0)
{
Out = 1;
}

else
if(In>0)
{
	Out = In;

}

}

#endif