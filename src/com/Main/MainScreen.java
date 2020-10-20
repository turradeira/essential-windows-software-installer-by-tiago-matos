package com.Main;

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.InputStream;
import java.io.OutputStream;
import java.io.IOException;
import java.lang.*;
import java.lang.ProcessBuilder;
import java.io.BufferedReader;
import java.io.InputStreamReader;

public class MainScreen
{
    //region variables
    private JButton install_button;
    private JCheckBox hwm_check;
    private JCheckBox discord_check;
    private JPanel panelMain;
    private JCheckBox steam_check;
    public boolean dis=false, hwm=false, steam=false;
    ProcessBuilder hw = new ProcessBuilder();
    //hw.command("C:\\Users\\tiaga\\Desktop\\essential software installer by tiago matos\\hwmonitor_1.42.exe");
    //endregion
    public MainScreen()
    {
        discord_check.addActionListener(new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent actionEvent)
            {

            }
        });

        hwm_check.addActionListener(new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent actionEvent)
            {

            }
        });

        steam_check.addActionListener(new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent actionEvent)
            {
            }
        });

        install_button.addActionListener(new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent actionEvent)
            {
                if(discord_check.isSelected() & hwm_check.isSelected() & steam_check.isSelected())
                {
                    JOptionPane.showMessageDialog(null,"Discord E hwmonitor e steam");
                }
                else if(discord_check.isSelected() & hwm_check.isSelected())
                {
                    JOptionPane.showMessageDialog(null,"Discord E hwmonitor");
                }
                else if(discord_check.isSelected() & steam_check.isSelected())
                {
                    JOptionPane.showMessageDialog(null,"Discord E steam");
                }
                else if(hwm_check.isSelected() & steam_check.isSelected())
                {
                    JOptionPane.showMessageDialog(null,"hwmonitor E steam");
                }
                else if(hwm_check.isSelected())
                {
                    JOptionPane.showMessageDialog(null,"Hardware Monitor");
                    //hw.start();
                }
                else if(steam_check.isSelected())
                {
                    JOptionPane.showMessageDialog(null,"Steam");
                }
                else if(discord_check.isSelected())
                {
                    JOptionPane.showMessageDialog(null,"Discord");
                }
            }
        });
    }

    public static void main(String[] args)
    {
        JFrame frame = new JFrame("MainScreen");
        frame.setContentPane(new MainScreen().panelMain);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.pack();
        frame.setVisible(true);
    }
}
