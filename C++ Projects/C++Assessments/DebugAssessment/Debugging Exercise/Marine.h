#pragma once
#include "Entity.h"
class Marine : public Entity
{
public:
	Marine();
	Marine(int mHP, int atk);
	~Marine();
	int iAttack() override;
	int squadSize();
	void takeDamage(int damage) override;

};

