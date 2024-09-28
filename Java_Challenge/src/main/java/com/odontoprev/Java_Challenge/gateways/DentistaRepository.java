package com.odontoprev.Java_Challenge.gateways;

import com.odontoprev.Java_Challenge.domains.Dentista;
import org.springframework.data.jpa.repository.JpaRepository;

public interface DentistaRepository extends JpaRepository<Dentista, String> {
}
