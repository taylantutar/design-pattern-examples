package model

import "fmt"

type IPhone interface {
	GetInformation() string
}

type Phone struct {
	Brand   string
	Name    string
	Color   string
	Storage string
}

type MotorolaPhone struct {
	Phone
}

func (m *MotorolaPhone) GetInformation()string {
	return fmt.Sprintf("Motorola Phone cereated. brand:%s,  name:%s, color:%s, storage:%s", m.Brand,m.Name,m.Color,m.Storage)
}

type SamsungPhone struct {
	Phone
}

func (s *SamsungPhone) GetInformation() string {
	return fmt.Sprintf("Samsung phone created. brand:%s,  name:%s, color:%s, storage:%s", s.Brand,s.Name,s.Color,s.Storage)
}
