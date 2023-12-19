package model

type BMW1Car struct {
	Car
}

func NewBMW1() ICar {
	return &BMW1Car{
		Car: Car{
			Brand: "BMW",
			Model: "118",
			Color: "Black",
		},
	}
}
