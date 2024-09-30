package com.odontoprev.Java_Challenge.usecases.impl;

import com.odontoprev.Java_Challenge.domains.Cliente;
import com.odontoprev.Java_Challenge.gateways.ClienteRepository;
import com.odontoprev.Java_Challenge.usecases.ClienteCadastrado;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

@Service
@RequiredArgsConstructor
public class ClienteCadastradoImpl implements ClienteCadastrado {

    private final ClienteRepository clienteRepository;

    @Override
    public Cliente executa(Cliente clienteParaSerCadastrado) {
        return clienteRepository.save(clienteParaSerCadastrado);
    }

}
