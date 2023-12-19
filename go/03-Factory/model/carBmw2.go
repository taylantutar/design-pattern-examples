package model

type BMW2Car struct {
	Car
}

func NewBMW2() ICar {
	return &BMW1Car{
		Car: Car{
			Brand: "BMW",
			Model: "220",
			Color: "Blue",
		},
	}
}
