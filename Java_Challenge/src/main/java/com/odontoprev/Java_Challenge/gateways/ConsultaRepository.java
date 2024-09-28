package com.odontoprev.Java_Challenge.gateways;

import com.odontoprev.Java_Challenge.domains.Consulta;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ConsultaRepository extends JpaRepository<Consulta, String> {
}
