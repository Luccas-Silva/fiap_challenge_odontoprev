package com.odontoprev.Java_Challenge.gateways;

import com.odontoprev.Java_Challenge.domains.Cliente;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ClienteRepository extends JpaRepository<Cliente, String> {
}
