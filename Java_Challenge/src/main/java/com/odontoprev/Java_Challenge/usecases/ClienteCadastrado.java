package com.odontoprev.Java_Challenge.usecases;

import com.odontoprev.Java_Challenge.domains.Cliente;
import org.springframework.stereotype.Service;

@Service
public interface ClienteCadastrado {
    Cliente executa(Cliente clienteParaSerCadastrado);
}
