#include <iostream>
#include <cassert>
#pragma once
//#define SIZE 10
using namespace std;

template <typename  X>
class tStack
{
	int sO = 10;
	const static size_t IncBy = 10;

	X *arr;
	size_t tSize;
	size_t tCapacity;
public:
	tStack()
	{
		X* temp = new X[sO];
		arr = temp;
		tSize = 0;
		tCapacity = 10;
	}
	tStack(const tStack &vec)
	{
		*this = vec;
	}
	~tStack()
	{
		delete[] arr;
	}
	X *data() {
		return arr;
	}

	void reserve(size_t newCapacity)
	{
		if (newCapacity > tCapacity)
		{
			X* temp = new X[newCapacity];
			for (size_t i = 0; i < tSize; i++)
			{
				temp[i] = arr[i];
			}
			delete[] arr;
			arr = temp;
			tCapacity = newCapacity;
		}
	}

	void pushBack(const X &value)
	{
		if (tSize == tCapacity) {
			reserve(tCapacity + IncBy);
		}

		arr[tSize] = value;
		tSize++;
	}

	void popBack() 
	{
		if (tSize >= 0)
		{
			arr[ tSize - 1 ] = NULL;
			tSize--;
		}
	}

	X &at(size_t index)
	{
		if ((index >= tSize || index < 0))
		{
			cout << "Number out of range" << std::endl;
		}
		
		return arr[index];
	}

	size_t size() const
	{
		return tSize;
	}

	size_t tCap() const
	{
		return tCapacity;
	}

	bool empty() const
	{
		if (tSize == 0) {
			return true;
		}
		else {
			return false;
		}
	}

	void resize(size_t t)
	{
		if (t > tCapacity) {
			resize(t);

		}
		
		if (t > tSize && t <= tCapacity) {
			for (size_t i = tSize; i < t; i++) {
				pushBack(0);
			}
		}

		if (t < tSize)
		{
			for (size_t i = 0; i < t; i++) {
				popBack();
			}
		}


	}

	void sTF()
	{
		tCapacity = tSize;
	}


	void clear()
	{
		for (size_t i = tSize; i > 0; i--)
		{
			popBack();
		}
		tSize = 0;
	}
	tStack& operator=(const tStack &vec) {
		reserve(vec.capacity);
		
		for (size_t i = 0; i < vec.size; i++)
		{
			pushBack(vec.arr[i]);
		}

		return *this;
	}

	X& operator[] (size_t index)
	{
		return arr[index];
	}
};